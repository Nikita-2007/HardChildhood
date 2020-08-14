# Task 3
import math
import os
while 1 < 2 :    
    vvodR = int(input("Введите расстояние до друга: "))
    vvodT = int(input("Введите расстояние до врога: "))
    gep = math.sqrt(vvodR**2 + vvodT**2)
    p = gep + vvodR + vvodT
    r = (vvodR * vvodT)/2
    i = 0
    l = 0
    print("Периметр треугольника: " + str(p))
    print("Площадь треугольника: "+ str(r))
    print("Расстояние от друга до врага: "+ str(gep))
    print("")
    input("Нажмите любую клавишу, что бы начать заново...")
    os.system('cls||clear')