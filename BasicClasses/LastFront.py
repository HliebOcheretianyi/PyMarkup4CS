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

        # Prompt template for code scenario (when specific document codes are mentioned)
        self.code_scenario_template = PromptTemplate.from_template("""
                system

                You are a senior C# programmer that writes code based on the provided context for SPECIFIC DOCUMENT CODES.

                CRITICAL REQUIREMENTS:
                - MANDATORY: Every response must start with '__Result = ' and use method calls, never hardcoded strings like '__Result = \"text\";'
                - ALWAYS start with "__Result = "
                - All classes you use are already declared and you can't make up new
                - ALWAYS use method calls or variable references instead of raw strings.
                - NEVER write: __Result = "some text"; (this is forbidden)
                - YOU MUST reference the specific document codes mentioned in the query: {extracted_codes}
                - Use methods like .FirstOrDefault() to find documents with these specific codes

                SUPER IMPORTANT!!!
                YOU CAN USE ONLY THIS OPERATORS AND NOTHING MORE: <, ||, &&, ==, !=, >, <=, >=, +, -, *, /, =, .
                YOU CAN reference specific document codes like {extracted_codes} using FirstOrDefault or similar methods
                DONT OVERCOMPLEX, DONT WRITE ANYTHING APART FROM ASKED

                Instructions:
                - All classes you use are already declared and you can't make up new
                - ALWAYS start with "__Result = "
                - Read the provided context carefully
                - Focus on the specific document codes: {extracted_codes}
                - Use only the information provided in the context
                - If the context doesn't contain enough information, say so and then try to write what you can
                - Be accurate and cite specific parts of the context when possible
                - Don't use LINQ

                Response format:
                - Plain code which can be straightforward pasted to the code editor
                - No markdown formatting, just plain C# code
                user

                CONTEXT DOCUMENTS: 
                {context_docs}

                CONTEXT CLASSES: 
                {context_classes}

                TASK: {question}
                SPECIFIC CODES TO USE: {extracted_codes}

                Please provide code that specifically handles these document codes: {extracted_codes}

                Answer:""")

        # Prompt template for empty scenario (when no specific codes are mentioned)
        self.empty_scenario_template = PromptTemplate.from_template("""
                system

                You are a senior C# programmer that writes GENERAL code based on the provided context.

                CRITICAL REQUIREMENTS:
                - MANDATORY: Every response must start with '__Result = ' and use method calls, never hardcoded strings like '__Result = \"text\";'
                - ALWAYS start with "__Result = "
                - All classes you use are already declared and you can't make up new
                - ALWAYS use method calls or variable references instead of raw strings.
                - NEVER write: __Result = "some text"; (this is forbidden)
                - DO NOT reference specific document codes or numbers
                - Write GENERAL implementation that works for any documents
                - Use generic property access and method calls

                SUPER IMPORTANT!!!
                YOU CAN USE ONLY THIS OPERATORS AND NOTHING MORE: <, ||, &&, ==, !=, >, <=, >=, +, -, *, /, =, .
                DO NOT reference specific document codes like 211, 212, etc.
                DONT OVERCOMPLEX, DONT WRITE ANYTHING APART FROM ASKED

                Instructions:
                - All classes you use are already declared and you can't make up new
                - ALWAYS start with "__Result = "
                - Read the provided context carefully
                - Write GENERAL code that doesn't depend on specific document codes
                - Use only the information provided in the context
                - If the context doesn't contain enough information, say so and then try to write what you can
                - Be accurate and cite specific parts of the context when possible
                - Don't use LINQ

                Response format:
                - Plain code which can be straightforward pasted to the code editor
                - No markdown formatting, just plain C# code

                WRONG EXAMPLES (NEVER DO THIS):
                __Result = "Some text"; // FORBIDDEN - hardcoded string
                __Result = documents.FirstOrDefault(x => x.Code == "211"); // FORBIDDEN - specific code reference
                __Result = "211"; // FORBIDDEN - specific code as string

                user

                CONTEXT DOCUMENTS: 
                {context_docs}

                CONTEXT CLASSES: 
                {context_classes}

                TASK: {question}

                Please provide GENERAL code that works for any documents without referencing specific codes.

                Answer:""")

    def prompt_generator(self, query, retrieved_docs):
        context_docs = "\n".join([
            f'Document {i + 1}: \n {doc}' for i, doc in enumerate(retrieved_docs['documents'])
        ])
        context_classes = "\n".join([
            f'Class {i + 1}: \n {clas}' for i, clas in enumerate(retrieved_docs['classes'])
        ])

        if retrieved_docs.get('has_codes', False):
            print(f"Using CODE SCENARIO template with codes: {retrieved_docs['extracted_codes']}")
            template = self.code_scenario_template
            prompt = template.format(
                context_docs=context_docs,
                context_classes=context_classes,
                question=query,
                extracted_codes=retrieved_docs['extracted_codes']
            )
        else:
            print("Using EMPTY SCENARIO template (general implementation)")
            template = self.empty_scenario_template
            prompt = template.format(
                context_docs=context_docs,
                context_classes=context_classes,
                question=query
            )

        return prompt

    def invoke(self, query, retrieved_docs, debug_mode=False):
        print("Retrieving documents...")
        prompt = self.prompt_generator(query, retrieved_docs)
        if debug_mode:
            print("=" * 50)
            print("GENERATED PROMPT:")
            print("=" * 50)
            print(prompt)
            print("=" * 50)
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

            # Get retrieval results with scenario information
            retrieved_docs = dq(question)

            print(f"\n=== SCENARIO DETECTED: {retrieved_docs['scenario'].upper()} ===")
            print(f"Has codes: {retrieved_docs['has_codes']}")
            if retrieved_docs['has_codes']:
                print(f"Extracted codes: {retrieved_docs['extracted_codes']}")

            result, attempt, duration, success = rag.invoke(question, retrieved_docs, debug_mode=True)
            print("\n" + "=" * 50)
            print("RESULT:")
            print("=" * 50)
            rag.llm.logger(question, result, attempt, duration, success)
            print(result)
    except KeyboardInterrupt:
        print("\nShutting down...")
    except Exception as e:
        print(f"Error: {e}")
    finally:
        if 'rag' in locals():
            rag.llm.stop()