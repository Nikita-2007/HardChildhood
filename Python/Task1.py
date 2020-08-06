import os
# Task 1
while 0 < 1:  
    x = input("Введите год - ")
    y = int(x)%4
    z = int(x)%100
    a = int(x)%400

    if y == 0 and z != 0:
        print("Высокосный")
    elif a == 0:
        print("Высокосный")
    else:
        print("Не Высокосный")
    input()
    os.system('cls')