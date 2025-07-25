import sys

from BasicClasses import SentenceTransformerEmbeddingFunction, OllamaLLM
from paths import DATA_FOLDER, PROCESSED_DATA_FOLDER, MODELS_FOLDER, ML_FOLDER
import chromadb
from FlagEmbedding import FlagReranker

import warnings
warnings.filterwarnings("ignore")


class RAG:
    def __init__(self, collection_name = 'my_rag_v1',
                 embedding_model = f'{ML_FOLDER}/BGE-m3',
                 ollama_model='gemma',
                 ollama_basic_url="http://localhost:11434"):
        print('Getting embedding function...')
        self.embedding_f = SentenceTransformerEmbeddingFunction(embedding_model)
        print('Done')
        print('Setting up ChromaDB client...')
        self.client = chromadb.PersistentClient(path=f'{DATA_FOLDER}/chromadb')
        print('Done')
        print('Getting collection...')
        self.collection = self.client.get_collection(name=collection_name, embedding_function=self.embedding_f)
        print('Done')
        print('Building a reranker...')
        self.reranker  = FlagReranker('BAAI/bge-reranker-v2-m3', use_fp16=True, cache_dir=f'{ML_FOLDER}/bge-reranker-v2-m3')
        print('Done')
        print('Connecting to Ollama...')
        self.llm = OllamaLLM(model_name=ollama_model, base_url=ollama_basic_url)
        print('Done')

    def get_documents(self, query, n=5):
        temp = self.collection.query(query_texts=query, n_results=n*6)
        pairs = [[query, temp['documents'][0][i]] for i in range(20)]
        new_scores = self.reranker.compute_score(pairs, normalize=True)

        result = list(zip(
            temp['ids'][0],
            temp['metadatas'][0],
            temp['documents'][0],
            new_scores
        ))
        result.sort(key=lambda x: x[3], reverse=True)
        return result[:7]

    def prompt_generator(self, query, retrieved_docs):
        context = "\n\n".join(
            f'Document {i + 1}: \n {doc[2]}' for i, doc in enumerate(retrieved_docs)
        )

        prompt = '\n'.join([
        "system",
                """You are a senior C# programmer that writes code based on the provided context.

                Instructions:
                - All classes you use are alredy declared and you can't make up new
                - start with "__Result = "
                - Read the provided context carefully
                - If multiple documents are provided, synthesize information from all relevant sources
                - Use only the information provided in the context
                - If the context doesn't contain enough information, say so and then try to write what you can
                - Be accurate and cite specific parts of the context when possible
                - Follow C# best practices and naming conventions
                - Include necessary using statements
                - Add brief comments for complex logic
            
                Response format:
                - Write at the start (AS A COMMENT) your confidence level (High/Medium/Low)
                - Plain code which can be straightforward pasted to the code editor
                - No markdown formatting, just plain C# code
                """,
        "human",
                f"""Context: {context}
    
                Request: {query}
            
                Please provide a comprehensive answer following the instructions above.
            
                Answer:"""])

        return prompt

    def invoke(self, query):
        print("Retrieving documents...")
        retrieved_docs = self.get_documents(query)
        prompt = self.prompt_generator(query, retrieved_docs)
        print("Now generating response\nWait for 2-3 minutes")
        answer = self.llm.generate(prompt)
        return answer


if __name__ == '__main__':

    rag = RAG()
    while True:
        question = ''
        while question == '':
            question = input('--------------------------\n'
                             'What would you like to do?\n'
                             '(/bye for stopping)\n').lower().strip()
            if question == '/bye':
                break
            result = rag.invoke(question)
            print("\n" + "=" * 50)
            print("RESULT:")
            print("=" * 50)
            print(result)


# TODO error handling
# notTODO fine-tuning
# DOne BGE reranking
# TODO BM25
# TODO C# checker