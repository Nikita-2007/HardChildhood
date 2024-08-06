from flask import Flask, render_template, request, redirect
from flask_sqlalchemy import SQLAlchemy
from datetime import datetime

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///sqlite.db'
db = SQLAlchemy(app)

class User(db.Model):
    id = db.Column(db.Integer, primary_key=True) #id
    login = db.Column(db.String(255), nullable=False) #Имя
    mail = db.Column(db.String(255), nullable=False) #Имя
    password = db.Column(db.String(255), nullable=False) #Имя
    date = db.Column(db.Date, default=datetime.utcnow) #времення метка

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

@app.route('/register', methods=['GET', 'POST'])
def register():
    if request.method == 'POST':
        login = request.form['login']
        mail = request.form['mail']
        password = request.form['password']
        user = User(login=login, mail=mail, password=password)
        try:
            db.session.add(user)
            db.session.commit()
            return redirect('/users')
        except:
            return 'Ошибка соеденения с базой данных'
    else:
        data = {
        'title':'Регестрация',
        'content': ''
        }
        return render_template("register.html", data=data)

@app.route('/profile')
def profile():
    data = {
        'title':'Профиль',
        'content':'Ваш профиль'
    }
    return render_template("profile.html", data=data)

@app.route('/users')
def users():
    data = {
        'title': 'Пользователи',
        'users': User.query.all()
    }
    return render_template("users.html", data=data)



if __name__ == '__main__':
    app.run(debug=True)
