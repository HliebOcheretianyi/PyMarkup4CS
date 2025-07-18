import chromadb
from sentence_transformers import SentenceTransformer
from transformers import AutoTokenizer, AutoModelForCausalLM
from transformers.utils import cached_file, WEIGHTS_NAME
from transformers.utils import TRANSFORMERS_CACHE
from langchain_core.prompts import PromptTemplate, ChatPromptTemplate
from langchain_core.messages import HumanMessage, SystemMessage
from langchain_core.runnables import RunnablePassthrough, RunnableLambda
from langchain_core.runnables.base import Runnable
import torch
from langchain_core.output_parsers import StrOutputParser
import os

DATA_FOLDER = '../data'
PROCESSED_DATA_FOLDER = '../data/processed_data'
MODELS_FOLDER = '../data/DocProperties/incore-exporter/Workflow.DTO/Models'
ML_FOLDER = '../data/ML'
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


class HuggingFaceModelWrapper(Runnable):
    """Simple wrapper to make HuggingFace model work with LangChain chains"""

    def __init__(self, model, tokenizer, max_length=512):
        self.model = model
        self.tokenizer = tokenizer
        self.max_length = max_length

        # Set pad token if not exists
        if self.tokenizer.pad_token is None:
            self.tokenizer.pad_token = self.tokenizer.eos_token

    def invoke(self, input, config=None, **kwargs):
        """Generate text from input"""
        # Convert input to string if it's a prompt object
        if hasattr(input, 'to_string'):
            prompt_text = input.to_string()
        else:
            prompt_text = str(input)

        # Tokenize input
        inputs = self.tokenizer(
            prompt_text,
            return_tensors="pt",
            max_length=self.max_length,
            truncation=True,
            padding=True
        )

        # Move to same device as model
        device = next(self.model.parameters()).device
        inputs = {k: v.to(device) for k, v in inputs.items()}

        # Generate
        with torch.no_grad():
            outputs = self.model.generate(
                **inputs,
                max_new_tokens=kwargs.get('max_new_tokens', 256),
                temperature=kwargs.get('temperature', 0.7),
                do_sample=kwargs.get('do_sample', True),
                pad_token_id=self.tokenizer.pad_token_id,
                eos_token_id=self.tokenizer.eos_token_id
            )

        # Decode response
        response = self.tokenizer.decode(
            outputs[0][inputs['input_ids'].shape[1]:],  # Only new tokens
            skip_special_tokens=True
        )

        return response


class CustomChromaRetriever(Runnable):
    def __init__(self, collection, k=10):
        self.collection = collection
        self.k = k

    def invoke(self, query, config=None):
        results = self.collection.query(
            query_texts=[query],
            n_results=self.k
        )
        return results


def setup_environment():
    # Fix 1: Check if local model exists, otherwise use HuggingFace
    local_model_path = f'{ML_FOLDER}/Qwen3-0.6B'

    if os.path.exists(local_model_path) and os.path.isdir(local_model_path):
        # Load from local path - explicitly specify it's a local path
        model = AutoModelForCausalLM.from_pretrained(
            local_model_path,
            local_files_only=True,  # This ensures it only looks locally
            trust_remote_code=True  # May be needed for some models
        )
        tokenizer = AutoTokenizer.from_pretrained(
            local_model_path,
            local_files_only=True,
            trust_remote_code=True
        )
    else:
        # Fallback to HuggingFace if local model doesn't exist
        print(f"Local model not found at {local_model_path}, loading from HuggingFace...")
        model = AutoModelForCausalLM.from_pretrained(CODE_MODEL_ID)
        tokenizer = AutoTokenizer.from_pretrained(CODE_MODEL_ID)

    # Wrap the model to make it LangChain compatible
    coding_model = HuggingFaceModelWrapper(model, tokenizer)

    # Option 1: Use ChatPromptTemplate for chat-based models
    basic_rag_prompt = ChatPromptTemplate.from_messages([
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


    # Fix 2: Apply same logic to embedding model
    local_embedding_path = f'{ML_FOLDER}/BGE-m3'
    if os.path.exists(local_embedding_path) and os.path.isdir(local_embedding_path):
        embedding_func = SentenceTransformerEmbeddingFunction(local_embedding_path)
    else:
        print(f"Local embedding model not found at {local_embedding_path}, loading from HuggingFace...")
        embedding_func = SentenceTransformerEmbeddingFunction(MODEL_ID)

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

    # Create the chain using RunnableLambda to wrap the format_docs function
    rag_chain = (
            {"context": retriever | RunnableLambda(format_docs), "question": RunnablePassthrough()}
            | prompt_template
            | llm
            | StrOutputParser()
    )

    return rag_chain


if __name__ == '__main__':
    coding_model, basic_rag_prompt, collection = setup_environment()
    retriever = CustomChromaRetriever(collection, k=10)

    # Fix 3: The original code had a logic error here
    query = 'What is your name?'
    retrieved_docs = retriever.invoke(query)
    rag_chain = create_rag_chain(retriever, coding_model, basic_rag_prompt)
    result = rag_chain.invoke(query)
    print(result)