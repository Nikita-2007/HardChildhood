# Yrock 8

x = 123454321
x = str(x)
print("Конвертация в строку -", x)
print("Повторение строки -", x * 10)
print("Сровнение строк abc > x -", "abc" > "x")
print("Сровнение строк a > b -", "a" > "b")
print("Сровнение строк a > B -", "a" > "B")
print("Код символа a -", ord("a"))
print("Поиск позиции символа в строке -", x.find("4"))
print("Точный поиск позиции символа в строке -", x.index("4"))
print("Поиск позиции символа в строке с конца -", x.rfind("4"))
print("Поиск позиции символа в строке от 4 символа до 6 -", x.find("4", 4, 6))
print("")

print("Замена символа -", x.replace("4", "ж"))
print("Замена символа -", x.replace("5", ""))
print("Замена символа несколько раз -", x.replace("3", "32123", 1))
print("")

x = "АБВЯУ абвяу -"
print("В заглавные -", x.upper())
print("В пропесные -", x.lower())
print("C заглавной буквы -", x.title())
print("C заглавной буквы 1 слово -", x.capitalize())
print("")

x = "123454321"
print("Подсчёт совподений -", x.count("4"))
print("Подсчёт совподений в деопозоне -", x.count("4", 1, 5))
print("Проверка на число -", x.isdigit())
print("Проверка на буквы -", x.isalpha())
x = "1 24 36 14 65 76 4 68"
print("Конвертация строки в список -", x.split())
x = "1, 24, 36, 14, 65, 76, 4, 68"
print("Конвертация строки в список с разделителем-", x.split(", "))
x = ["a", "b", "c"]
print("Конвертация списка в строку -", "".join(x))
x = "1 21 125 65 43 76 32"
print("Вывод строки с дополнением в конце -", x.ljust(50, "*"))
print("Вывод строки с дополнением в начале -", x.rjust(50, "*"))
print(x)
print("Символ номер 7 -", x[7])
print("Срез от 7 до 12 -", x[7:12])
print("Последний символ -", x[-1])
print("Последнии 5 символов -", x[-5:])
print("Первые 10 символов -", x[:10])
print("Срез сиволов с шагом 2 -", x[::2])
x = [1, 2, 3, 4, 5, 6, 7, 8, 9]
del x[3]
print("Удолить 3 символ -", x)
del x[3:5]
print("Удалить с 3 по 5 символ -", x)
x[2] = "АБВЯУ"
print("Замена 2 символа -", x)
input()