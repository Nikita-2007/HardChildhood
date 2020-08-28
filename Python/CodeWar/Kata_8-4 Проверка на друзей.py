def friend(x):
    x2 = []
    for i in x:
        if len(i) == 4:
            x2.append(i)
    return x2

#для локального запуска
test = ["Ryan", "Kieran", "Mark"]
print(friend(test))

input()
