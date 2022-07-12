print("Введите время прихода первого человека:")
h1, m1 = map(int, input().split(':'))
print("Введите время прихода второго человека:")
h2, m2 = map(int, input().split(':'))
if (h1 < 0 or h1 > 23 or m1 < 0 or m1 > 59 or h2 < 0 or h2 > 23 or m2 < 0 or m2 > 59):
    print("Некоректные данные")
else:
    d = abs((h1*60+m1) - (h2*60+m2))
    if (d < 15 or d > 1425):
        print("Встреча состоится")
    else:
        print("Встреча не состоится")
