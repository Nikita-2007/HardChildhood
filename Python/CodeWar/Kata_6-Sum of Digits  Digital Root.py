def digital_root(n):
    rez = n
    while n // 10 > 0:
        rez = 0
        for i in str(n):
            rez += int(i)
        n = rez
    return rez

#для локального запуска
print(digital_root(9))
