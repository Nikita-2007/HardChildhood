# Task 1
import os 

os.system('mode con cols=40 lines=10')

while 0 < 1:  
    x = input("Введите год - ")
    y = int(x)%4
    z = int(x)%100
    a = int(x)%400

    if y == 0 and z != 0 or a == 0:
        print("Высокосный")
    else:
        print("Не Высокосный")
    input('Нажмите Enter для продолжения...')
    os.system('cls||clear')
    
#if 4  x%4 == 0 and  x%100 or != 0 400: