# Task 4
import math
import os
while 1 < 2 :
    os.system("color 07")
    x = input("Введите длину  первой стороны треугольника - ")
    y = input("Введите длину  второй стороны треугольника - ")
    z = input("Введите длину третьей стороны треугольника - ")
    if x + y < z or x + z < y or y + z < x:
        os.system('cls||clear')
        os.system("color 04")
        print("Треугольник невозможен")
    else:
        os.system('cls||clear')
        os.system("color 02")
        print("Треугольник возможен")
    print("Нажмите любую клавишу, что бы начать заново...")
    input()
    os.system('cls||clear')
