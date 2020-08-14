# Task 5
import math

Xv = int(input("Введите свои кординаты по X: "))
Yv = int(input("Введите свои кординаты по Y: "))

Xb = int(input("Введите взрыв кординаты по X: "))
Yb = int(input("Введите взрыв кординаты по Y: "))
x = Xb-Xv
y = Yb-Yv
if math.hypot(x, y) > 5000:
    print("Вы выживете, так как центер взрыва от вас в " + str(math.hypot(x, y)), "метров")
else:
    print("Вы умрёте, так как центер взрыва от вас в " + str(math.hypot(x, y)), "метров")
input()