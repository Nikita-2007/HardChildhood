from flask import Flask, render_template
from flask_sqlalchemy import SQLAlchemy
from datetime import datetime

app = Flask(__name__)
app.config['SQLALCHEMY_DATABASE_URI'] = 'sqlite:///sqlite.db'
db = SQLAlchemy(app)

class User(db.Model):
    id = db.Column(db.Integer, primary_key=True) #id
    name = db.Column(db.String(255), nullable=False) #Имя
    discription = db.Column(db.Text, default='Not found') #Описание
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

@app.route('/users')
def users():
    users = User.query.all()
    return render_template("users.html", data=users)

if __name__ == '__main__':
    app.run(debug=True)
