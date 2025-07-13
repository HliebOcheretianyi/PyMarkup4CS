import chromadb
from sentence_transformers import SentenceTransformer
from transformers import AutoTokenizer, AutoModelForCausalLM
from transformers.utils import cached_file, WEIGHTS_NAME
from transformers.utils import TRANSFORMERS_CACHE
from langchain_core.prompts import PromptTemplate
from langchain_core.messages import HumanMessage, SystemMessage
from langchain_core.runnables import RunnablePassthrough
from langchain_core.output_parsers import StrOutputParser

DATA_FOLDER = '/data'
PROCESSED_DATA_FOLDER = '/data/processed_data'
MODELS_FOLDER = '/data/DocProperties/incore-exporter/Workflow.DTO/Models'
ML_FOLDER = '/data/ML'
MODEL_ID = "BAAI/bge-m3"
CODE_MODEL_ID = "Qwen/Qwen3-0.6B"


class SentenceTransformerEmbeddingFunction:
    def __init__(self, model_name_or_path):
        self.model_name = model_name_or_path
        self.model = SentenceTransformer(model_name_or_path)

    def __call__(self, input):
        embeddings = self.model.encode(input, normalize_embeddings=True, device='cuda:0')
        return embeddings.tolist()

    def name(self):
        return self.model_name


class CustomChromaRetriever:
    def __init__(self, collection, k=10):
        self.collection = collection
        self.k = k

    def invoke(self, query):
        results = self.collection.query(
            query_texts=[query],
            n_results=self.k
        )
        return results


def setup_environment():
    coding_model = AutoModelForCausalLM.from_pretrained(f'{ML_FOLDER}/Qwen3-0.6B')
    basic_rag_prompt = PromptTemplate.from_messages([
        ("system", """You are a senior C# programmer that writes code based on the provided context.

        Instructions:
        - Read the provided context carefully
        - If multiple documents are provided, synthesize information from all relevant sources
        - Use only the information provided in the context
        - If the context doesn't contain enough information, say so and then try to write what you can
        - Be accurate and cite specific parts of the context when possible

        Response format:
        - Write at the start (AS A COMMENT) your confidence level (High/Medium/Low)
        - Plain code which can be  straightfully pasted to the code editor
        """),
        ("human", """Context: {context}

        Request: {question}

        Please provide a comprehensive answer following the instructions above.

        Answer:""")
    ])

    embedding_func = SentenceTransformerEmbeddingFunction(f'{ML_FOLDER}/BGE-m3')
    chrome_persistent_client = chromadb.PersistentClient(path=f'{DATA_FOLDER}/chromadb')
    collection = chrome_persistent_client.get_collection(name='my_rag_v1', embedding_function=embedding_func)


    return coding_model, basic_rag_prompt, collection


def create_rag_chain(retriever, llm, prompt_template):
    """Create a RAG chain with retriever, LLM, and prompt"""

    def format_docs(result):
        """Format retrieved documents for the prompt"""

        documents = result['documents'][0]
        metadatas = result['metadatas'][0]
        distances = result['distances'][0]
        ids = result['ids'][0]

        context_for_llm = []
        for i, (doc, metadata, distance, doc_id) in enumerate(zip(documents, metadatas, distances, ids)):
            context_for_llm.append({
                'rank': i + 1,
                'content': doc,
                'category': metadata['category'],
                'id': doc_id,
                'similarity_score': distance
            })

            formatted_context = ""
            for item in context_for_llm:
                formatted_context += f"""
                --- Document {item['rank']} (ID: {item['id']}) ---
                Category: {item['category']}
                Similarity Score: {item['similarity_score']:.4f}
                Content:
                {item['content']}

                """

        return formatted_context.strip()

    # Create the chain
    rag_chain = (
        {"context": retriever | format_docs, "question": RunnablePassthrough()}
        | prompt_template
        | llm
        | StrOutputParser()
    )

    return rag_chain


if __name__ == '__main__':
    coding_model, basic_rag_prompt, collection = setup_environment()
    retriever = CustomChromaRetriever(collection, k=10)

    question = retriever.invoke(query='What is your name?')
    rag_chain = create_rag_chain(question, coding_model, basic_rag_prompt)
    rag_chain.invoke(question)