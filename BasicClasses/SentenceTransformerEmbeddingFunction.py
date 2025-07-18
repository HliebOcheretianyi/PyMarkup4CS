from sentence_transformers import SentenceTransformer


class SentenceTransformerEmbeddingFunction:
    def __init__(self, model_name_or_path):
        self.model_name = model_name_or_path
        self.model = SentenceTransformer(model_name_or_path)

    def __call__(self, input):
        embeddings = self.model.encode(input, normalize_embeddings=True, device='cuda:0')
        return embeddings.tolist()

    def name(self):
        return self.model_name


