
from sentence_transformers import SentenceTransformer
import numpy as np


class SentenceTransformerEmbeddingFunction:
    def __init__(self, model_name_or_path):
        self.model_name = model_name_or_path
        self.model = SentenceTransformer(model_name_or_path)

    def __call__(self, input):
        if isinstance(input, str):
            embeddings = self.model.encode([input], normalize_embeddings=True, device='cuda:0', batch_size=2)
            return embeddings.tolist()
        elif isinstance(input, list):
            embeddings = self.model.encode(input, normalize_embeddings=True, device='cuda:0', batch_size=2)
            return embeddings.tolist()
        else:
            raise ValueError(f"Unsupported input type: {type(input)}")

    def name(self):
        return self.model_name



if __name__ == "__main__":
    pass