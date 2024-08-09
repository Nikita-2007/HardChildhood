from flask import render_template, request, redirect
from app import app, db
from model.user import User

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

@app.route('/users')
def users():
    data = {
        'title': 'Пользователи',
        'users': User.query.all()
    }
    return render_template("users.html", data=data)

@app.route('/user/<int:id>')
def user(id):
    data = {
        'title': 'Профиль',
        'user': User.query.get(id),
    }
    return render_template("user.html", data=data)

@app.route('/user/<int:id>/update', methods=['GET', 'POST'])
def user_update(id):
    user = User.query.get(id)
    if request.method == 'POST':
        login = request.form['login']
        mail = request.form['mail']
        password = request.form['password']
        user = User(login=login, mail=mail, password=password)
        try:
            #db.session.update(user)
            db.session.commit()
            return redirect('/users')
        except:
            return 'Ошибка соеденения с базой данных'
    else:
        data = {
            'title':'Редактировать профиль',
            'user': user
        }
        return render_template("update.html", data=data)
@app.route('/user/<int:id>/delete')
def user_delete(id):
    user = User.query.get_or_404(id)
    try:
        db.session.delete(user)
        db.session.commit()
        return redirect('/users')
    except:
        return 'Ошибка соеденения с базой данных'