from BasicClasses import *


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