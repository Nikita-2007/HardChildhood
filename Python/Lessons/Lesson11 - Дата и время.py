# Yrock 11

import datetime

x = datetime.time(18, 30, 15, 120)
print("Время: ", x)
print("Тип данных: ", type(x))
print("Час: ", x.hour)
print("Минуты: ", x.minute)
print("Секунды: ", x.second)
print("Микросекунды: ", x.microsecond)
print()

x = datetime.date.today()
print("Сегодня: ", x)
print("Тип данных: ", type(x))
print("Год: ", x.year)
print("месяц: ", x.month)
print("День: ", x.day)
print("День недели (0-6): ", x.weekday())
print()

x = datetime.datetime(1961, 4, 12)
print("Сейчас дата и время: ", x)
print("Тип данных: ", type(x))
print("Час: ", x.hour)
print("Минуты: ", x.minute)
print("День недели (1-7): ", x.isoweekday())
print()

y = datetime.datetime.today()
delta = y - x
print(type(delta))
print("Период между датами в днях: ", delta.days)
print("Период между датами в секундах: ", delta.total_seconds())
print("Сравнение дат: ", y > x)
print()

x = y.year
print("Выборка данных:", x)
print("Формат выборки данных:", type(x))

input()