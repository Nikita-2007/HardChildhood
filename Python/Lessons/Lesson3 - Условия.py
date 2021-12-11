# Yrock 3

x = True
y = False
print(x == y)
print("")

x = 5
y = 6
z = x == y
print(z)
print("")

print(x != y)
print("")

print(x > y)
print("")

print(x <= y)
print("")

print(x > 0 and y > 0)
print("")

print(x < 0 or y  < 0)
print("")

print(not x == y)
print("")

if x > 0:
    print("Число", x, "- больше 0")
elif x == 0:
    print("Число", x, "- ровно 0")
else:
    print("Число", x, "- меньше 0")
print("")

if 4 < x < 6:
    print("ДВОЙНОЕ СРОВНЕНИЕ " + str(x))
print("")

if x > 0:
    if x == 5:
        print("Число", x, "- больше 0 и равен 5")
else:
    print("Число", x, "- больше 0")
print("")

print(all([1, 12, "x", "abc", True, 2 > 10]))
print(any([0,12, "", "", False, 2 > 10]))
print("Да") if x < 10 else print("Нет")
if all([5 > 3, 1 > 0, 72 < 73, 23 == 23, ]):
    print("Да")
else:
    print("Нет")
input()


