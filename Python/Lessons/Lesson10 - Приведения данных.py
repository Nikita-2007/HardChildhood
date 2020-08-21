# Yrock 10

# int - int - int
def Int_int_int(x):
    print("Ввод:", x, "- тип данных", type(x))
    res = x*2
    return res
res = Int_int_int(100)
print("Вывод:", res, "- тип данных", type(res))
print()

# str - str - str
x = "200"
print("Ввод:", x, "- тип данных", type(x))
res = x+x
print("Вывод:", res, "- тип данных", type(res))
print()

# int - int - str
x = 380
print("Ввод:", x, "- тип данных", type(x))
res = str(x//10) + " Попугаев"
print("Вывод:", res, "- тип данных", type(res))
print()

# int - str - str
x = 123
print("Ввод:", x, "- тип данных", type(x))
res = str(x)[::-1]
print("Вывод:", res, "- тип данных", type(res))
print()

# int - str - int
x = 123
print("Ввод:", x, "- тип данных", type(x))
res = int(str(x)[::-1])
print("Вывод:", res, "- тип данных", type(res))
print()

# str - str - int
x = "123"
print("Ввод:", x, "- тип данных", type(x))
res = int(x+x)
print("Вывод:", res, "- тип данных", type(res))
print()

# str - int - str
x = "123"
print("Ввод:", x, "- тип данных", type(x))
res = str(int(x)*2)
print("Вывод:", res, "- тип данных", type(res))
print()


# str - int - int
x = "123"
print("Ввод:", x, "- тип данных", type(x))
res = int(x)+10
print("Вывод:", res, "- тип данных", type(res))
print()

input()