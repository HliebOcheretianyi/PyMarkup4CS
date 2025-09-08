import time
from concurrent.futures import ThreadPoolExecutor
import chromadb
from paths import *
from BasicClasses import SentenceTransformerEmbeddingFunction, OllamaLLM
from langchain_core.prompts import PromptTemplate
from langchain_core.output_parsers import StrOutputParser
from langchain_core.runnables import RunnableLambda
import torch
import json
from transformers import AutoTokenizer, AutoModelForSequenceClassification

class DualQuery:
    def __init__(self, n_class=10, n_train=10, n_valid=3,
                 ollama_model='gemma',
                 ollama_basic_url="http://localhost:11434"):
        self.query = ''
        self.n_class = n_class
        self.n_train = n_train
        self.n_valid = n_valid
        print("Getting ChromaDB client...")
        self.client = chromadb.PersistentClient(path=f'{DATA_FOLDER}/chromadb')
        print("Setting up an embedding function...")
        embedding_func=SentenceTransformerEmbeddingFunction(f'{ML_FOLDER}/BGE-m3')
        print("Getting classes...")
        self.classes = self.client.get_collection('classes', embedding_function=embedding_func)
        print("Getting training data...")
        self.training = self.client.get_collection('training', embedding_function=embedding_func)
        print("Setting up a reranker...")
        self.tokenizer = AutoTokenizer.from_pretrained('BAAI/bge-reranker-v2-m3',
                                                       cache_dir=f'{ML_FOLDER}/bge-reranker-v2-m3')
        self.reranker = AutoModelForSequenceClassification.from_pretrained('BAAI/bge-reranker-v2-m3',
                                                                           cache_dir=f'{ML_FOLDER}/bge-reranker-v2-m3')
        self.device = "cuda:0" if torch.cuda.is_available() else "cpu"
        self.reranker.to(self.device)
        if torch.cuda.is_available():
            self.reranker.half()
        self.llm = OllamaLLM(model_name=ollama_model, base_url=ollama_basic_url)
        self.llm.start()

    def reciprocal_rank_fusion(self, results: list[list], k=60):
        """ Reciprocal_rank_fusion that takes multiple lists of ranked documents
            and an optional parameter k used in the RRF formula """

        # Initialize a dictionary to hold fused scores for each unique document
        fused_scores = {}

        # Iterate through each list of ranked documents
        for docs in results:
            # Iterate through each document in the list, with its rank (position in the list)
            for rank, doc in enumerate(docs):
                # Convert the document to a string format to use as a key (assumes documents can be serialized to JSON)
                doc_str = json.dumps(doc)
                # If the document is not yet in the fused_scores dictionary, add it with an initial score of 0
                if doc_str not in fused_scores:
                    fused_scores[doc_str] = 0
                # Retrieve the current score of the document, if any
                previous_score = fused_scores[doc_str]
                # Update the score of the document using the RRF formula: 1 / (rank + k)
                fused_scores[doc_str] += 1 / (rank + k)

        # Sort the documents based on their fused scores in descending order to get the final reranked results
        reranked_results = [
            (json.loads(doc), score)
            for doc, score in sorted(fused_scores.items(), key=lambda x: x[1], reverse=True)
        ]

        # Return the reranked results as a list of tuples, each containing the document and its fused score
        return reranked_results

    def rag_fusion(self, question):
        template = """You are a helpful assistant that generates multiple search queries based on a single input query. \n
        Generate multiple search queries related to: {question} \n
        Output (4 queries):"""

        fusion = PromptTemplate.from_template(template)

        generate_runnable = RunnableLambda(lambda x: self.llm.generate(str(x)))

        docs_runnable = RunnableLambda(
            lambda queries: [self.get_documents(q) for q in queries]
        )
        classes_runnable = RunnableLambda(
            lambda queries: [self.get_classes(q) for q in queries]
        )

        rrf_runnable = RunnableLambda(lambda results: self.reciprocal_rank_fusion(results))

        generate_queries = (
                fusion
                | generate_runnable
                | StrOutputParser()
                | (lambda x: x.split("\n"))
        )

        retrieval_chain_rag_fusion_docs = generate_queries | docs_runnable | rrf_runnable
        retrieval_chain_rag_fusion_classes = generate_queries | classes_runnable | rrf_runnable

        docs = retrieval_chain_rag_fusion_docs.invoke({"question": question})
        classes = retrieval_chain_rag_fusion_classes.invoke({"question": question})

        return docs, classes

    def compute_score(self, pairs, normalize=True, batch_size=2):
        scores = []
        for i in range(0, len(pairs), batch_size):
            batch_pairs = pairs[i:i + batch_size]
            inputs = [f"{pair[0]} [SEP] {pair[1]}" for pair in batch_pairs]
            tokenized = self.tokenizer(inputs, padding=True, truncation=True,
                                       max_length=2048, return_tensors="pt")
            tokenized = {k: v.to(self.device) for k, v in tokenized.items()}

            with torch.no_grad():
                outputs = self.reranker(**tokenized)
                batch_scores = outputs.logits.squeeze(-1).cpu().numpy()
                scores.extend(batch_scores)

        if normalize:
            scores = torch.softmax(torch.tensor(scores), dim=0).numpy()

        return scores

    def __call__(self, query):
        self.query = query.strip()
        try:
            with ThreadPoolExecutor(max_workers=2) as executor:
                future_documents = executor.submit(self.get_documents)
                classes_future = executor.submit(self.get_classes)
                documents = future_documents.result()
                classes = classes_future.result()
                return {
                    'documents': [doc[2] for doc in documents],
                    'classes': classes['documents'],
                    'query': query
                }
        except Exception as e:
            raise RuntimeError(f"Failed to execute query '{query}': {str(e)}") from e

    def get_documents(self, query=None):
        if query:
            self.query = query
        raw = self.training.query(query_texts=[self.query], n_results=self.n_train, where={'category': 'code + explanation'})
        pairs = [(self.query, doc) for doc in raw['documents'][0]]
        new_scores = self.compute_score(pairs, normalize=True, batch_size=4)

        scored_docs = sorted(
            zip(raw['ids'][0], raw['metadatas'][0], raw['documents'][0], new_scores),
            key=lambda x: x[3],
            reverse=True
        )
        return scored_docs[:self.n_valid]

    def get_classes(self, query=None):
        if query:
            self.query = query
        return self.classes.query(query_texts=[self.query], n_results=self.n_class, where={'category': 'classes'})

    def benchmark_batch_sizes(self, sizes=[1, 2, 4, 8, 12, 16, 24, 32, 48, 64]):
        results = {}
        raw = self.training.query(query_texts=[self.query], n_results=self.n_train)
        pairs = [(self.query, doc) for doc in raw['documents'][0]]
        for batch_size in sizes:
            start = time.time()
            scores = self.compute_score(pairs, batch_size=batch_size)
            end = time.time()
            results[batch_size] = end - start
            print(f"Batch size {batch_size}: {end - start:.2f}s")
        return results

if __name__ == '__main__':
    start = time.time()
    dq = DualQuery()
    result = dq("write an insurance for a group of 3 people going to the country")


    for doc in result['documents']:
        print(doc)
    print('-------------------------')
    for clas in result['classes'][0]:
        print(clas)

    end = time.time()
    print(f"Execution time: {end - start:.2f} seconds")
