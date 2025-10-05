import time
import chromadb
from paths import *
from BasicClasses import SentenceTransformerEmbeddingFunction, OllamaLLM, SimpleGrammarNER
from langchain_core.prompts import PromptTemplate
from langchain_core.output_parsers import StrOutputParser
from langchain_core.runnables import RunnableLambda
import torch
import json
import numpy as np
from transformers import AutoTokenizer, AutoModelForSequenceClassification

class NumpyEncoder(json.JSONEncoder):
    def default(self, obj):
        if isinstance(obj, np.integer):
            return int(obj)
        elif isinstance(obj, np.floating):
            return float(obj)
        elif isinstance(obj, np.ndarray):
            return obj.tolist()
        return super(NumpyEncoder, self).default(obj)


class DualQuery:
    def __init__(self, n_class=10, n_train=10, n_valid=3,
                 ollama_model='gemma',
                 ollama_basic_url="http://localhost:11434"):
        self.query = ''
        self.n_class = n_class
        self.n_train = n_train
        self.n_valid = n_valid

        print(f"[INFO: {time.asctime()}] \t\tSetting up NER...")
        self.ner = SimpleGrammarNER()
        print(f"\t[INFO: {time.asctime()}] \tNER Initialized.")
        print(f"[INFO: {time.asctime()}] \t\tGetting ChromaDB client...")
        self.client = chromadb.PersistentClient(path=f'{DATA_FOLDER}/chromadb')
        print(f"\t[INFO: {time.asctime()}] \tChromaDB initialized.")
        print(f"[INFO: {time.asctime()}] \t\tSetting up an embedding function...")
        embedding_func=SentenceTransformerEmbeddingFunction(f'{ML_FOLDER}/BGE-m3')
        print(f"\t[INFO: {time.asctime()}] \tEmbedding function initialized.")
        print(f"[INFO: {time.asctime()}] \t\tGetting classes...")
        self.classes = self.client.get_collection('classes', embedding_function=embedding_func)
        print(f"\t[INFO: {time.asctime()}] \tClasses initialized.")
        print(f"[INFO: {time.asctime()}] \t\tGetting training data...")
        self.training = self.client.get_collection('training', embedding_function=embedding_func)
        print(f"\t[INFO: {time.asctime()}] \tTraining data initialized.")
        print(f"[INFO: {time.asctime()}] \t\tSetting up a reranker...")
        self.tokenizer = AutoTokenizer.from_pretrained('BAAI/bge-reranker-v2-m3',
                                                       cache_dir=f'{ML_FOLDER}/bge-reranker-v2-m3')
        self.reranker = AutoModelForSequenceClassification.from_pretrained('BAAI/bge-reranker-v2-m3',
                                                                           cache_dir=f'{ML_FOLDER}/bge-reranker-v2-m3')
        self.device = "cuda:0" if torch.cuda.is_available() else "cpu"
        self.reranker.to(self.device)
        if torch.cuda.is_available():
            self.reranker.half()
        print(f"\t[INFO: {time.asctime()}] \tReranker initialized.")
        self.llm = OllamaLLM(model_name=ollama_model, base_url=ollama_basic_url)
        self.llm.start()

    def analyze_query_for_codes(self, query):
        try:
            entities = self.ner.extract_entities(query)
            document_codes = [entity[0] for entity in entities if entity[1] == "DOCUMENT CODE"]
            has_codes = len(document_codes) > 0

            print(f"NER Analysis: Found {len(document_codes)} document codes: {document_codes}")
            return has_codes, document_codes
        except Exception as e:
            print(f"NER analysis failed: {e}, defaulting to no codes")
            return False, []

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

    def reciprocal_rank_fusion(self, results: list[list], k=60):
        # Initialize a dictionary to hold fused scores for each unique document
        fused_scores = {}

        # Iterate through each list of ranked documents
        for docs in results:
            # Iterate through each document in the list, with its rank (position in the list)
            for rank, doc in enumerate(docs):
                # Convert the document to a string format to use as a key using custom encoder
                doc_str = json.dumps(doc, cls=NumpyEncoder, sort_keys=True)

                # If the document is not yet in the fused_scores dictionary, add it with an initial score of 0
                if doc_str not in fused_scores:
                    fused_scores[doc_str] = 0
                # Update the score of the document using the RRF formula: 1 / (rank + k)
                fused_scores[doc_str] += 1 / (rank + k)

        # Sort the documents based on their fused scores in descending order to get the final reranked results
        reranked_results = [
            (json.loads(doc), score)
            for doc, score in sorted(fused_scores.items(), key=lambda x: x[1], reverse=True)
        ]

        # Return the reranked results as a list of tuples, each containing the document and its fused score
        return reranked_results

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

    def generate_scenario_specific_queries(self, question, has_codes=False, codes=None):
        if has_codes:
            # Code scenario - generate queries that focus on specific document codes
            template = """You are a helpful assistant that generates multiple search queries for finding code examples with specific document codes.

            The user mentioned these document codes: {codes}

            Generate multiple search queries related to: {question}
            Focus on finding examples that use these specific codes.

            Output (4 queries):"""

            fusion = PromptTemplate.from_template(template)
            prompt_input = {"question": question, "codes": ", ".join(codes)}
        else:
            # Empty scenario - generate general queries without specific codes
            template = """You are a helpful assistant that generates multiple search queries for general code examples.

            Generate multiple search queries related to: {question}
            Focus on general implementation patterns, do NOT mention specific document codes or numbers.

            Output (4 queries):"""

            fusion = PromptTemplate.from_template(template)
            prompt_input = {"question": question}

        return fusion, prompt_input

    def rag_fusion(self, question, has_codes=False, codes=None):
        fusion, prompt_input = self.generate_scenario_specific_queries(question, has_codes, codes)

        def generate_with_pseudo(x):
            query_text = self.llm.generate(str(x))
            queries = query_text.split('\n')

            pseudocodes = []
            for query in queries:
                if query.strip():
                    pseudo = self.llm.generate_pseudocode(query)
                    pseudocodes.append({
                        'query': query,
                        'pseudocode': pseudo
                    })
            return queries, pseudocodes
        pseudo_runnable = RunnableLambda(generate_with_pseudo)
        generate_runnable = RunnableLambda(lambda x: self.llm.generate(str(x)))

        docs_runnable = RunnableLambda(
            lambda queries: [self.get_documents(q) for q in queries]
        )
        classes_runnable = RunnableLambda(
            lambda queries: [result['documents'][0] for q in queries for result in [self.get_classes(q)]]
        )

        rrf_runnable = RunnableLambda(lambda results: self.reciprocal_rank_fusion(results))

        queries_and_pseudo = (
            fusion | pseudo_runnable
        )

        generate_queries = (
                fusion
                | generate_runnable
                | StrOutputParser()
                | (lambda x: x.split("\n"))
        )

        retrieval_chain_rag_fusion_docs = generate_queries | docs_runnable | rrf_runnable
        retrieval_chain_rag_fusion_classes = generate_queries | classes_runnable | rrf_runnable

        result = queries_and_pseudo.invoke(prompt_input)
        queries, pseudocodes = result

        docs = retrieval_chain_rag_fusion_docs.invoke(prompt_input)
        classes = retrieval_chain_rag_fusion_classes.invoke(prompt_input)

        template = """
    You are an expert code architect specializing in synthesizing multiple implementation strategies into optimal solutions.

    OBJECTIVE:
    Given multiple search queries and their corresponding pseudocode plans, create a unified, production-ready pseudocode that represents the best synthesis of all approaches.

    
    SYNTHESIS REQUIREMENTS:
    1. Pattern Recognition: Identify and leverage common patterns across all input plans
    2. Best Practice Selection: Extract and combine the most effective approaches from each plan
    3. Redundancy Elimination: Remove duplicate logic and consolidate overlapping functionality
    4. Optimization: Streamline the solution for clarity, efficiency, and maintainability
    5. Structural Coherence: Ensure logical flow and clear step-by-step progression
    6. You cant declare new classes or methods, only the ones you saw
    7. All classes you use are already declared and you can't make up new
    8. ALWAYS start with "__Result = "
    9. Read the provided context carefully
    
    REFERENCE EXAMPLES:
    The following C# implementations demonstrate the expected output quality and style:
    
    {docs}
    
    INPUT DATA:
    Pseudocode Plans to Synthesize:
    {pseudocodes}
    
    Target Task:
    {question}
    
    OUTPUT REQUIREMENTS:
    - Produce ONLY the synthesized pseudocode—no explanations, comments, or meta-discussion
    - Use clear, descriptive variable and function names
    - Maintain consistent indentation and structure
    - Include logical operators and control flow statements
    - Focus on algorithmic clarity over implementation details
    - Ensure the pseudocode is immediately translatable to C#
    
    Generate the unified pseudocode now:
    """

        summary_prompt = PromptTemplate.from_template(template)

        pseudocodes_text = "\n\n".join([
            f"Query {i + 1}: {item['query']}\n{item['pseudocode']}"
            for i, item in enumerate(pseudocodes)
        ])

        final_pseudocode = self.llm.generate(
            summary_prompt.format(
                docs=docs,
                pseudocodes=pseudocodes_text,
                question=question,
            )
        )

        return docs, classes, final_pseudocode

    def __call__(self, query):
        self.query = query.strip()
        try:
            has_codes, extracted_codes = self.analyze_query_for_codes(query)

            documents, classes, final_pseudocode = self.rag_fusion(query, has_codes, extracted_codes)

            return {
                'documents': [doc[0][2] for doc in documents],
                'classes': [cla for cla, score in classes],
                'pseudocode': final_pseudocode,
                'query': query,
                'has_codes': has_codes,
                'extracted_codes': extracted_codes,
                'scenario': 'code_scenario' if has_codes else 'empty_scenario'
                    }
        except Exception as e:
            raise RuntimeError(f"Failed to execute query '{query}': {str(e)}") from e

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

    # Test with codes
    result1 = dq("виведи страхові поля для документів 211 а також 1234")
    print("=== Test with codes ===")
    print(f"Scenario: {result1['scenario']}")
    print(f"Has codes: {result1['has_codes']}")
    print(f"Extracted codes: {result1['extracted_codes']}")
    print(f"Generated pseudocode: {result1['pseudocode']}")

    # Test without codes
    # result2 = dq("write an insurance for a group of 3 people going to the country")
    # print("\n=== Test without codes ===")
    # print(f"Scenario: {result2['scenario']}")
    # print(f"Has codes: {result2['has_codes']}")
    # print(f"Extracted codes: {result2['extracted_codes']}")
    # print(f"Generated pseudocode: {result2['pseudocode']}")

    end = time.time()
    print(f"Execution time: {end - start:.2f} seconds")
