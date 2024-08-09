from datetime import datetime
from app import db

class User(db.Model):
    id = db.Column(db.Integer, primary_key=True) #id
    login = db.Column(db.String(255), nullable=False) #Имя
    mail = db.Column(db.String(255), nullable=False) #Имя
    password = db.Column(db.String(255), nullable=False) #Имя
    date = db.Column(db.Date, default=datetime.utcnow) #времення метка