import os
import re
import subprocess
import atexit
import time
import requests
import pandas as pd
from paths import DATA_FOLDER


class OllamaLLM:
    """
    hf.co/unsloth/Qwen2.5-Coder-14B-Instruct-128K-GGUF:Q2_K
    hf.co/bartowski/open-r1_OlympicCoder-7B-GGUF:Q4_K_M
    gemma
    """
    def __init__(self, model_name="gemma", base_url="http://localhost:11434"):
        self.model_name = model_name
        self.base_url = base_url
        self.api_url = f"{base_url}/api/generate"
        self.process = None
        self.log_table = None

    def __enter__(self):
        self.start()
        return self

    def __exit__(self, exc_type, exc_val, exc_tb):
        self.stop()

    def start(self):
        if self.is_running():
            print("Ollama server already running")
            return

        try:
            self.process = subprocess.Popen(
                ['ollama', 'serve'],
                stdout=subprocess.DEVNULL,
                stderr=subprocess.DEVNULL
            )

            atexit.register(self.stop)

            for _ in range(30):
                if self.is_running():
                    print("Ollama server started")
                    return
                time.sleep(1)

            raise RuntimeError("Server failed to start")

        except Exception as e:
            print(f"Failed to start Ollama: {e}")
            raise

    def stop(self):
        if self.process:
            self.process.terminate()
            self.process.wait()
            print("Ollama server stopped")
            self.process = None

    def is_running(self):
        try:
            response = requests.get('http://localhost:11434/api/version', timeout=1)
            return response.status_code == 200
        except:
            return False

    def generate(self, prompt):
        payload = {
            "model": self.model_name,
            "prompt": prompt,
            "stream": False,
            "options": {
                    "stop": [
                        "<end_of_turn>",
                        "<eos>"
                    ],
                    "temperature": 0.3, #1
                    "min_p" : 0.01,
                    "repeat_penalty" : 1.1, #1.3
                    "top_k" : 20, #64
                    "top_p" : 0.95,
                    "num_predict" : 16384,
                    "num_ctx" : 32768
            }
        }

        try:
            response = requests.post(self.api_url, json=payload, timeout=300)
            response.raise_for_status()
            return response.json()["response"]
        except requests.exceptions.RequestException as e:
            print(f"Error calling Ollama API: {e}")
            return None

    def generate_pseudocode(self, original_query):
        pseudocode_prompt = f"""
                {original_query}

                IMPORTANT: Before writing the actual C# code, first create a step-by-step pseudo code plan.

                Please follow this format:
                1. First, write your pseudo code plan inside <PSEUDOCODE> tags
                dont think about robustness and error handling

                Example format:
                <PSEUDOCODE>
                1. Check if customer has orders
                2. Count the number of orders
                3. Convert count to string
                4. Return the result
                </PSEUDOCODE>

                Now provide your solution:
                """

        print("Generating pseudo code and reasoning...")
        response = self.generate(pseudocode_prompt)
        return response


    def validator(self, code):
        problems = []
        lines = code.splitlines()
        # forbidden_patterns = [
        #     r'__Result\s*=\s*"[^"]*"(?!\s*\+)',
        #     r"__Result\s*=\s*'[^']*'(?!\s*\+)",
        #     r'__Result\s*=\s*"[^"]*"\s*;',
        #     r"__Result\s*=\s*'[^']*'\s*;",
        # ]

        result_assignments = []
        for i, line in enumerate(lines):
            if re.search(r'__Result\s*=', line, re.IGNORECASE):
                result_assignments.append((i, line))

        # Check if the LAST __Result assignment is hardcoded
        if result_assignments:
            last_assignment = result_assignments[-1][1]

            # Only flag if the final assignment is hardcoded (not initialization)
            if re.search(r'__Result\s*=\s*"[^"]*"\s*;?\s*$',
                         last_assignment) and '"---"' not in last_assignment and '""' not in last_assignment:
                problems.append(f"Final __Result assignment is hardcoded: {last_assignment}")

        return len(problems) == 0, problems


    def logger(self, question, response, attempts, time, success):
        flag = os.path.isfile(f"{DATA_FOLDER}/logs_responses.csv")
        d = {
            'Question': question,
            'Response': response,
            'Attempts': attempts,
            'Time': time,
            'Success': success
        }
        if not flag: # False
            df = pd.DataFrame(data=[d], columns=['Question', 'Response', 'Attempts', 'Time', 'Success'])
            df.to_csv(f"{DATA_FOLDER}/logs_responses.csv", index=False)
        if flag: # True
            df = pd.read_csv(f"{DATA_FOLDER}/logs_responses.csv")
            df.loc[len(df)] = d
            df.to_csv(f"{DATA_FOLDER}/logs_responses.csv", index=False)
        return flag

    def generation_with_validation(self, original_prompt):
        prompt = original_prompt
        attempt = 1
        while True:
            start = time.time()
            if attempt == 15:
                duration = time.time() - start
                return last_variant, attempt, duration, False
            print(f'Attempt #{attempt}')
            variant = self.generate(prompt)
            last_variant = variant
            is_valid, problems = self.validator(variant)

            if is_valid:
                print("No issues found!")
                duration = time.time() - start
                return last_variant, attempt, duration, True
            attempt += 1
            print(f"Such a pity\n {problems}")
            prompt_addition = f"""
                               CRITICAL: Previous attempt failed because it used hardcoded strings. 
                               Issues found: {'; '.join(problems)}
                               
                               REMEMBER:
                               - NEVER write __Result = "text"; 
                               - ALWAYS use method calls like: __Result = object.Property?.ToString() ?? "---";
                               - ALWAYS use property access like: __Result = item.Value.ToString("N2");
                               - Use .FirstOrDefault(), .ToString(), .Count(), .Sum() etc.
                            
                               Try again with dynamic code only:
                               """

            prompt = original_prompt + prompt_addition


if __name__ == '__main__':
    pass