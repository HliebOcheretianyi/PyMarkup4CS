

from fastapi import FastAPI
from pydantic import BaseModel
import logging

# Set up logging
logging.basicConfig(level=logging.INFO)
logger = logging.getLogger(__name__)

class QuestionRequest(BaseModel):
    question: str

app = FastAPI()

@app.get("/")
def root():
    logger.info("GET / endpoint called")
    print("GET ROOT CALLED!")
    return {"message": "Hello World"}

@app.post("/response")
def response(question: QuestionRequest):
    logger.info(f"POST /response called with: {question.question}")
    print(f"POST RESPONSE CALLED: {question.question}")
    return {"received": question.question}