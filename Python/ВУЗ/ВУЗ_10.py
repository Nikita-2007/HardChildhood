s, l1, r1, l2, r2 = map(int, input("Введите значение чисел(s1, l1, r1, l2, r2): ").split())
if (1e15 <= abs(s) or 1e15 <= abs(l1) or 1e15 <= abs(r1) or 1e15 <= abs(l2) or 1e15 <= abs(r2) or l1 >= r1 or l2 >= r2): print("Некоректные данные")
if (l1 + l2 <= s and r1 + r2 >= s):
    if (s - l1 <= r2): print(l1, s - l1)
    else: print(r1, s - r1)
else: print(-1)
