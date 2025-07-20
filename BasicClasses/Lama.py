import requests


class OllamaLLM:
    def __init__(self, model_name="gemma", base_url="http://localhost:11434"):
        self.model_name = model_name
        self.base_url = base_url
        self.api_url = f"{base_url}/api/generate"

    def generate(self, prompt):
        payload = {
            "model": self.model_name,
            "prompt": prompt,
            "stream": False,
            "options": {
                    "temperature": 1.0,
                    "min_p" : 0.01,
                    "repeat_penalty" : 1.0,
                    "top_k" : 64,
                    "top_p" : 0.95,
                    "num_predict" : 32768,
                    "num_ctx" : 8192
            }
        }

        try:
            response = requests.post(self.api_url, json=payload, stream=True)
            response.raise_for_status()
            return response.json()["response"]
        except requests.exceptions.RequestException as e:
            print(f"Error calling Ollama API: {e}")
            return None