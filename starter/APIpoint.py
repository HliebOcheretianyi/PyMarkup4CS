import flask
from BasicClasses import *


app = flask.Flask(__name__)
dq = DualQuery()
model = LastFront()

@app.route('/')
def main():
    return 'Hello World!'

@app.route('/api/generator', methods=['POST'])
def generator():
    question = flask.request.get_json()['question']
    retrieved_docs = dq(question)
    result, attempt, duration, success = model.invoke(question, retrieved_docs, debug_mode=False)
    model.llm.logger(question, result, attempt, duration, success)
    return {'result': result}

if __name__ == '__main__':
    app.run(debug=True, use_reloader=False)