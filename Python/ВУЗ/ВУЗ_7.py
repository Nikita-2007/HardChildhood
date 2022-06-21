n = int(input("Введите способ решения: "))
if (n == 1):
    a = float(input("Введите знчения a: "))
    b = float(input("Введите знчения b: "))
    c = float(input("Введите знчения c: "))
    p = (a + b + c)/2
    S = (p * (p - a) * (p - b) * (p - c))**0.5
    if ((a + b + c) - max(a, b, c) > max(a, b, c)):
        print(int(S))
    else:
        print("Некорректные данные")
elif (n == 2):
    x1, y1 = map(float, input("Введите координаты a: ").split())
    x2, y2 = map(float, input("Введите координаты b: ").split())
    x3, y3 = map(float, input("Введите координаты c: ").split())
    S = abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2 
    a = (((y1 - x1) **  2) + ((y2 - x2) ** 2) ) ** 0.5
    b = (((y2 - x2)  ** 2) + ((y3 - x3) ** 2) ) ** 0.5
    c = (((y3 - x3) **  2) + ((y1 - x1) ** 2) ) ** 0.5
    if (a + b + c) - max(a, b, c) > max(a, b, c):
        print(int(S))
    else:
        print("Некорректные данные")
else:
    print("Несущестующий способ решения")
