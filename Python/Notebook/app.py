from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
@app.route('/index')
def index():
    data = {
        'title':'Главная страница',
        'content':'Тест индекс'
    }
    return render_template("index.html", data=data)

@app.route('/about')
def about():
    data = {
        'title':'О проекте',
        'content':'Тест описания'
    }
    return render_template("about.html", data=data)

if __name__ == '__main__':
    app.run(debug=True)
