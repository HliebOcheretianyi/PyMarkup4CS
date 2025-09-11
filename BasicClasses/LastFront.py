from BasicClasses import OllamaLLM, DualQuery
from langchain_core.prompts import PromptTemplate


class LastFront:
    def __init__(self,
                 ollama_model='gemma',
                 ollama_basic_url="http://localhost:11434"):

        print('Connecting to Ollama...')
        self.llm = OllamaLLM(model_name=ollama_model, base_url=ollama_basic_url)
        self.llm.start()
        print('Done')

        self.prompt_template = PromptTemplate.from_template("""
        system

        You are a senior C# programmer that writes code based on the provided context.

        CRITICAL REQUIREMENTS:
        - MANDATORY: Every response must start with '__Result = ' and use method calls, never hardcoded strings like '__Result = \"text\";'
        - ALWAYS start with "__Result = "
        - All classes you use are already declared and you can't make up new
        - ALWAYS use method calls or variable references instead of raw strings.
        - NEVER write: __Result = "some text"; (this is forbidden)

        SUPER IMPORTANT!!!
        YOU CAN USE ONLY THIS OPERATORS AND NOTHING MORE: <, ||, &&, ==, !=, >, <=, >=, +, -, *, /, =, .
        YOU CANT TAKE CODES OF DOCUMENTS like 112 234 and other, USE METHOD FirstOrDefault instead
        YOU CANT USE THIS GetProductTypeCode()
        DONT OVERCOMPLEX, DONT WRITE ANYTHING APART FROM ASKED

        Instructions:
        - All classes you use are already declared and you can't make up new
        - ALWAYS start with "__Result = "
        - Read the provided context carefully
        - If multiple documents are provided, synthesize information from all relevant sources
        - Use only the information provided in the context
        - If the context doesn't contain enough information, say so and then try to write what you can
        - Be accurate and cite specific parts of the context when possible
        - Dont't use LINQ

        Response format:
        - Plain code which can be straightforward pasted to the code editor
        - No markdown formatting, just plain C# code

        CORRECT EXAMPLES:
        __Result = customer.Orders.Count().ToString();
        __Result = policy.Premium.ToString("N2");
        __Result = items.Sum(x => x.Amount).ToString("C");

        WRONG EXAMPLES (NEVER DO THIS):
        __Result = "Some text"; // FORBIDDEN - hardcoded string
        __Result = "123"; // FORBIDDEN - hardcoded number as string
        __Result = "Customer Name"; // FORBIDDEN - any hardcoded text
        __Result = "Hardcoded text"; // BAD - don't use hardcoded strings

        user

        CONTEXT DOCUMENTS: 
        {context_docs}

        CONTEXT CLASSES: 
        {context_classes}

        TASK: {question}

        Please provide a comprehensive answer following the instructions above.

        Answer:""")

    def prompt_generator(self, query, retrieved_docs):
        context_docs = "\n".join([
            f'Document {i + 1}: \n {doc}' for i, doc in enumerate(retrieved_docs['documents'])
        ])
        context_classes = "\n".join([
            f'Class {i + 1}: \n {clas}' for i, clas in enumerate(retrieved_docs['classes'])
        ])

        prompt = self.prompt_template.format(
            context_docs=context_docs,
            context_classes=context_classes,
            question=query
        )

        return prompt

    def invoke(self, query, retrieved_docs, debug_mode=False):
        print("Retrieving documents...")
        prompt = self.prompt_generator(query, retrieved_docs)
        if debug_mode:
            print(prompt)
        print("Now generating response\nWait for 2-3 minutes")
        answer, attempt, duration, success = self.llm.generation_with_validation(prompt)
        return answer, attempt, duration, success

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
            prompt = rag.prompt_generator(question, retrieved_docs)
            pseudo = rag.llm.generation_with_validation(prompt)
            print(pseudo)
            # result, attempt, duration, success = rag.invoke(question, retrieved_docs, debug_mode=True)
            # print("\n" + "=" * 50)
            # print("RESULT:")
            # print("=" * 50)
            # rag.llm.logger(question, result, attempt, duration, success)
            # print(result)
    except KeyboardInterrupt:
        print("\nShutting down...")
    except Exception as e:
        print(f"Error: {e}")
    finally:
        if 'rag' in locals():
            rag.llm.stop()