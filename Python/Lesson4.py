# Yrock 4
import random

x = 0
while x < 10:
    x += 1
    print(x)
print("")

Game_over = False
while not Game_over:
    x += 1
    if x > 20:
        Game_over = True
    print(x)
print("")
    
# Циклы for: стоп, старт-стоп, старт-стоп-шаг
for i in range(5):
    print(i)
print("")
    
for i in range(10, 13):
    print(i)
print("")
    
for i in range(100, 200, 20):
    print(i)
print("")

x = [-10, -5, 20, 100, 5000]
print(x)
print(type(x))
for i in x:
    print(i)
print("")

for i in "Hello Word":
    print(i)
print("")
    
# Цикл В Цикле

for i in range(2, 11):
    for j in range(2, 11):
        print(i * j, end = " ")
    print("")

# break / continue

x = [11, 22, 33, 44, 55, 66, 77, 88, 99]
print(x)
# Случайная сортировка массива
random.shuffle(x)
print(x)
while True:

    print("Рандом от 0 до 1 -", random.random())
    print("Рандом от 100 до 200 -", random.randint(100, 200))
    print("Рандом РЭИНДЖ до 10 -", random.randrange(10))
    print("Рандом РЭИНДЖ от 1000 до 2000 -", random.randrange(1000, 2000))
    print("Рандом РЭИНДЖ от 90 до 180 делить 3 -", random.randrange(90, 180, 3))
    print("Рандом из списка -", random.choice(x))
    y = input('Выйти - 0, продолжить - !0 - ')
    if y == "0":
        break
    else:
        continue
print("")

input()