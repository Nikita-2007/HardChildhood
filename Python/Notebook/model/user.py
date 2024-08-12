from datetime import datetime
from app import db
from model.city import City

class User(db.Model):
    id = db.Column(db.Integer, primary_key=True) #id
    login = db.Column(db.String(255), nullable=False) #Имя
    mail = db.Column(db.String(255), nullable=False) #Почта
    password = db.Column(db.String(255), nullable=False) #Пароль
    date = db.Column(db.Date, default=datetime.utcnow) #времення метка
    city_id = db.Column(db.Integer, db.ForeignKey(City.id), nullable=True) #ключ города