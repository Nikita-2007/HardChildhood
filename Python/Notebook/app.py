from flask import Flask, render_template

app = Flask(__name__)

@app.route('/')
@app.route('/index')
def index():
    data = {
        'title':'Главная страница',
        'content':'Записная книжка'
    }
    return render_template("index.html", data=data)

@app.route('/login')
def login():
    data = {
        'title':'Вход',
    }
    return render_template("login.html", data=data)

@app.route('/register')
def register():
    data = {
        'title':'Регестрация',
    }
    return render_template("register.html", data=data)

@app.route('/profile')
def profile():
    data = {
        'title':'Профиль',
        'content':'Ваш профиль'
    }
    return render_template("profile.html", data=data)

if __name__ == '__main__':
    app.run(debug=True)
