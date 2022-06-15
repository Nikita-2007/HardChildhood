a = float(input('Введите a: '))
b = float(input('Введите b: '))
c = float(input('Введите c: '))
D = b*b-4*a*c
if D > 0 and a != 0:
    print("x1 =", int((-b+(D**0.5))//(2*a)))
    print("x2 =", int((-b-(D**0.5))//(2*a)))
elif D == 0:
    print("x =", int(-b//(2*a)))
elif a == 0:
    print("x =", int(-b//c))
else:
    print("Корнй нет т.к. Дискрименант меньше 0")
