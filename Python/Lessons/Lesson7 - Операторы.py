# Yrock 7

x = 5 #input("Ввод в консоль ")
print("Конвертация в число", int(x))
print("Конвертация в дробь", float(x))
print()

x = "HelloWord"
print("Длина строки", len(x))
print("Конвертация в строку", str(len(x)) + "ed")
print("Трансформация в список", list(x))
print("Трансформация в картеж", tuple(x))
colors = [("Красный", 2), ("Зелёынй", 1), ("Синий", 3), ("Фиолетовый", 5)]
print("Список картежей", colors)
colors = dict(colors)
print("Трансформация в словарь", colors)
print()

x = [94, 2, 34, 23, 63, 89, 73, 23, 73, 63]
print("Список", x)
print("Минимальное значение", min(x))
print("Максимальное значение", max(x))
print("Сортировка списка", sorted(x))
print("Сортировка списка наоборот", sorted(x, reverse = True))
print("Сумма списка", sum(x))
print("Сумма цикла списка", sum(i**2 for i in x))
print("")

print("Набор", set(x))
print("Фиксированный Набор", frozenset(x))
print("")

print("bool любого числа", bool(-125))
print("bool любого числа", bool(0))
print("bool любого символа", bool("-125"))
print("bool любого символа", bool(""))

input()