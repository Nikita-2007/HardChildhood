from flask import render_template, request, redirect
from app import app, db
from model.user import User
from model.city import City

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
        city_id = request.form['city_id']
        user = User(login=login, mail=mail, password=password, city_id=city_id)
        try:
            db.session.add(user)
            db.session.commit()
            return redirect('/users')
        except:
            return 'Ошибка соеденения с базой данных'
    else:
        data = {
            'title':'Регестрация',
            'city_id': City.query.all()
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
    user = User.query.get(id)
    user.city_id =  City.query.get(user.city_id).name
    data = {
        'title': 'Профиль',
        'user': user
    }
    return render_template("user.html", data=data)

@app.route('/user/<int:id>/update', methods=['GET', 'POST'])
def user_update(id):
    user = User.query.get(id)
    if request.method == 'POST':
        user.login = request.form['login']
        user.mail = request.form['mail']
        user.password = request.form['password']
        user.city_id = request.form['city_id']
        try:
            db.session.commit()
            return redirect('/users')
        except:
            return 'Ошибка соеденения с базой данных'
    else:
        data = {
            'title':'Редактировать профиль',
            'user': user,
            'city_id': City.query.all()
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