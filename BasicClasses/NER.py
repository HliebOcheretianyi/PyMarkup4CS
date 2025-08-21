import spacy
import pickle
from spacy import displacy
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.metrics.pairwise import cosine_similarity
from spacy.lang.uk.stop_words import STOP_WORDS
import pandas as pd
from paths import *

class SimpleGrammarNER:
    def __init__(self, model_name="uk_core_news_sm", pickle_path=f'{ML_FOLDER}/NLPickles/ner_components.pkl'):
        self.nlp = spacy.load(model_name)
        self.pickle_path = pickle_path

        with open(self.pickle_path, 'rb') as f:
            components = pickle.load(f)

        self.semantic_seeds = components['semantic_seeds']
        self.vectorizer = components['vectorizer']
        self.tfidf_matrix = components['tfidf_matrix']
        self.entity_vectors = components['entity_vectors']

        # raw_semantic_seeds = [
        #     "код",
        #     "ідентифікатор",
        #     "номер",
        #     "страховий код",
        #     "тип програми",
        #     "код типу страхування",
        #     "страхування",
        #     "програма"
        # ]
        # semantic = []
        # for word in raw_semantic_seeds:
        #     doc = self.nlp(word)
        #     lemmas = " ".join([token.lemma_ for token in doc])
        #     semantic.append(lemmas)
        #
        # # Насіннєві слова для кожного класу
        # self.semantic_seeds = {
        #     "DOCUMENT CODE": semantic
        # }
        #
        # # Побудуємо TF-IDF вектори тільки для seed-слов
        # all_texts = [" ".join(seeds) for seeds in self.semantic_seeds.values()]
        # self.vectorizer = TfidfVectorizer()
        # self.tfidf_matrix = self.vectorizer.fit_transform(all_texts)
        #
        # self.entity_vectors = {}
        # for i, label in enumerate(self.semantic_seeds.keys()):
        #     self.entity_vectors[label] = self.tfidf_matrix[i]

    def save_to_pickle(self):
        components = {
            'semantic_seeds': self.semantic_seeds,
            'vectorizer': self.vectorizer,
            'tfidf_matrix': self.tfidf_matrix,
            'entity_vectors': self.entity_vectors,
            # Note: We don't pickle the spaCy model as it's better loaded fresh
        }

        with open(self.pickle_path, 'wb') as f:
            pickle.dump(components, f)
        print(f"Components saved to {self.pickle_path}")

    def calculate_similarity(self, text, entity_type):
        vec = self.vectorizer.transform([text])
        return cosine_similarity(vec, self.entity_vectors[entity_type])[0, 0]

    def extract_entities(self, text, threshold=0.2):
        text = " ".join([word for word in text.split() if word.lower() not in STOP_WORDS])
        text = text.strip()
        text = text.replace('"', '').replace("/", "").replace('\\', "").replace(',', '').replace('.', '')
        text = " ".join(text.split())
        doc = self.nlp(text)

        candidates = []

        # for i, token in enumerate(doc):
            # # Випадок PROPN (імена, географічні назви)
            # if token.pos_ == "PROPN":
            #     candidates.append(token.text)
            #
            # # Випадок ADJ+NOUN
            # if i < len(doc) - 1 and token.pos_ == "ADJ" and doc[i+1].pos_ == "NOUN":
            #     candidates.append(f"{token.text} {doc[i+1].text}")

        for i, token in enumerate(doc):
            # NUM + NOUN (наприклад, "521 код")
            if i < len(doc) - 1 and token.pos_ == "NUM" and doc[i + 1].pos_ == "NOUN":
                candidates.append(f"{token.text} {doc[i + 1].lemma_}")

            # NOUN + NUM NUM NUM... (наприклад, "код 521 322 18")
            if token.pos_ == "NOUN":
                nums = []
                j = i + 1
                while j < len(doc) and doc[j].pos_ == "NUM":
                    nums.append(doc[j].text)
                    j += 1
                if nums:
                    cand = f"{token.lemma_} {' '.join(nums)}"
                    candidates.append(cand)

        # Перевірка семантикою
        entities = []
        for cand in candidates:
            best_label, best_score = None, 0
            for label in self.semantic_seeds.keys():
                sim = self.calculate_similarity(cand.lower(), label)
                if sim > best_score:
                    best_label, best_score = label, sim
            if best_score >= threshold:
                entities.append((cand, best_label, best_score))

        return entities


# 🔹 Приклад використання
if __name__ == "__main__":
    ner = SimpleGrammarNER()
    text = 'Код повертає текстове значення покриття за умовою «ВОЄННІ ДІЇ» для програми з кодом типу страхування "211", "212", "213", "214", "221", "222", "223" або "224", якщо знайдено відповідний параметр. Якщо значення параметра — «В розмірі 15% від страхової суми, але не більше 300 000 грн», результат:«дорівнює 15% від страхової суми, але не більше 300 000,00 грн агрегатно за Договором за цією умовою».Якщо значення — «В розмірі повної вартості ТЗ, але не більше 2 млн грн», результат:«дорівнює страховій сумі, зазначеній в п. 6.3 Частини 1 Договору, але не більше 2 000 000,00 грн».Якщо програма або параметр відсутні — повертає "---".'
    ents = []
    # ents.extend(ner.extract_entities(text))
    # for e in ents:
    #     print(f"{e[0]} -> {e[1]} (similarity {e[2]:.2f})")
    # print("Знайдені сутності:", ents)

    df = pd.read_excel(f'{DATA_FOLDER}/DocProperties/DocProperties_NEW_filled.xlsx')
    for line in df['Description']:
        ents.extend(ner.extract_entities(line))

    for e in ents:
        print(f"{e[0]} -> {e[1]} (similarity {e[2]:.2f})")
