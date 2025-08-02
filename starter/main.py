from BasicClasses import OllamaLLM, DualQuery


class LastFront:
    def __init__(self,
                 ollama_model='gemma',
                 ollama_basic_url="http://localhost:11434"):

        print('Connecting to Ollama...')
        self.llm = OllamaLLM(model_name=ollama_model, base_url=ollama_basic_url)
        self.llm.start()
        print('Done')

    def prompt_generator(self, query, retrieved_docs):
        context_docs = "\n".join([
                                f'Document {i + 1}: \n {doc}' for i, doc in enumerate(retrieved_docs['documents'])
                            ])
        context_classes = "\n".join([
            f'Class {i + 1}: \n {clas}' for i, clas in enumerate(retrieved_docs['classes'][0])
        ])

        prompt = '\n'.join([
        "system",
                """You are a senior C# programmer that writes code based on the provided context.

                CRITICAL REQUIREMENTS:
                
                - "MANDATORY: Every response must start with '__Result = ' and use method calls, never hardcoded strings like '__Result = \"text\";'"
                - ALWAYS start with "__Result = " (this is mandatory)
                - All classes you use are already declared and you can't make up new
                - NEVER write: __Result = "some text"; (this is forbidden)
                - Use .FirstOrDefault() methods to find parameters

                Instructions:
                - All classes you use are alredy declared and you can't make up new
                - ALWAYS start with "__Result = "
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
                
                WRONG EXAMPLE (Don't do this):
                __Result = "Hardcoded text"; // BAD - don't use hardcoded strings
                """,
        "user",
                f"""CONTEXT DOCUMENTS: {context_docs}
    
                CONTEXT CLASSES: {context_classes}
    
                TASK: {query}
            
                Please provide a comprehensive answer following the instructions above.
            
                Answer:"""])

        return prompt

    def invoke(self, query, retrieved_docs, debug_mode=False):
        print("Retrieving documents...")
        prompt = self.prompt_generator(query, retrieved_docs)
        if debug_mode:
            print(prompt)
        print("Now generating response\nWait for 2-3 minutes")
        answer = self.llm.generate(prompt)
        return answer

    def __del__(self):
        if hasattr(self, 'llm') and self.llm:
            self.llm.stop()


if __name__ == '__main__':
    try:
        dq = DualQuery()
        rag = LastFront()
        while True:
            question = ''
            while question == '':
                question = input('--------------------------\n'
                                 'What would you like to do?\n'
                                 '(/bye for stopping)\n').lower().strip()
                if question == '/bye':
                    break

            if question == '/bye':
                break

            retrieved_docs = dq(question)
            result = rag.invoke(question, retrieved_docs, debug_mode=True)
            print("\n" + "=" * 50)
            print("RESULT:")
            print("=" * 50)
            print(result)
    except KeyboardInterrupt:
        print("\nShutting down...")
    except Exception as e:
        print(f"Error: {e}")
    finally:
        if 'rag' in locals():
            rag.llm.stop()

# TODO error handling
# notTODO fine-tuning
# DOne BGE reranking

# TODO BM25
# TODO C# checker