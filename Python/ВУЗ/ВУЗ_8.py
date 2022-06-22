a, x, b = input().split()
if x == '+':
    print(float(a) + float(b))
elif x == '-':
    print(float(a) - float(b))
elif x == '*':
    print(float(a) * float(b))
elif x == '/':
    print(float(a) / float(b))
else: print('Ошибка ввода')
