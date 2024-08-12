from app import db

class City(db.Model):
    id = db.Column(db.Integer, primary_key=True) #id
    name = db.Column(db.String(255), nullable=False) #Имя