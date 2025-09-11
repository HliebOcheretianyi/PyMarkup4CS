import torch
from sentence_transformers import SentenceTransformer


class SentenceTransformerEmbeddingFunction:
    def __init__(self, model_name_or_path):
        self.model_name = model_name_or_path
        self.model = SentenceTransformer(model_name_or_path)
        self.device = "cuda:0" if torch.cuda.is_available() else "cpu"

    def __call__(self, input):

        if isinstance(input, str):
            embeddings = self.model.encode([input], normalize_embeddings=True, device=self.device, batch_size=2)
            return embeddings.tolist()
        elif isinstance(input, list):
            embeddings = self.model.encode(input, normalize_embeddings=True, device=self.device, batch_size=2)
            return embeddings.tolist()
        else:
            raise ValueError(f"Unsupported input type: {type(input)}")


    def name(self):
        return self.model_name



if __name__ == "__main__":
    pass