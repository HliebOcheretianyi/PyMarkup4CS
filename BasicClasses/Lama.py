import itertools
import re
import subprocess
import atexit
import time
import requests

class OllamaLLM:
    def __init__(self, model_name="gemma", base_url="http://localhost:11434"):
        self.model_name = model_name
        self.base_url = base_url
        self.api_url = f"{base_url}/api/generate"
        self.process = None

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
                    "temperature": 1.0,
                    "min_p" : 0.01,
                    "repeat_penalty" : 1.3,
                    "top_k" : 64,
                    "top_p" : 0.95,
                    "num_predict" : 32768,
                    "num_ctx" : 16384
            }
        }

        try:
            response = requests.post(self.api_url, json=payload, timeout=300)
            response.raise_for_status()
            return response.json()["response"]
        except requests.exceptions.RequestException as e:
            print(f"Error calling Ollama API: {e}")
            return None

    def validator(self, code):
        problems = []
        forbidden_patterns = [
            r'__Result\s*=\s*"[^"]*"(?!\s*\+)',
            r"__Result\s*=\s*'[^']*'(?!\s*\+)",
            r'__Result\s*=\s*"[^"]*"\s*;',
            r"__Result\s*=\s*'[^']*'\s*;",
        ]

        for forbidden_pattern in forbidden_patterns:
            match = re.findall(forbidden_pattern, code, re.IGNORECASE)
            if match:
                problems.extend(match)

        return len(problems) == 0, problems

    def generation_with_validation(self, original_prompt, attempts=5):
        prompt = original_prompt
        for attempt in range(attempts):
            print(f'Attempt #{attempt + 1}')
            variant = self.generate(prompt)
            last_variant = variant
            is_valid, problems = self.validator(variant)

            if is_valid:
                print("No issues found!")
                return last_variant
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
        return variant
