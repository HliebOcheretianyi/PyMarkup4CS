import time
from concurrent.futures import ThreadPoolExecutor
import chromadb
from paths import *
from BasicClasses import SentenceTransformerEmbeddingFunction
import torch
from transformers import AutoTokenizer, AutoModelForSequenceClassification

class DualQuery:
    def __init__(self, n_class=10, n_train=60, n_valid=5):
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

    def get_documents(self):
        raw = self.training.query(query_texts=[self.query], n_results=self.n_train, where={'category': 'code + explanation'})
        pairs = [(self.query, doc) for doc in raw['documents'][0]]
        new_scores = self.compute_score(pairs, normalize=True, batch_size=4)

        scored_docs = sorted(
            zip(raw['ids'][0], raw['metadatas'][0], raw['documents'][0], new_scores),
            key=lambda x: x[3],
            reverse=True
        )
        return scored_docs[:self.n_valid]

    def get_classes(self):
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
