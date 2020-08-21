def filter_list(l):
    l2 = []
    for i in l:
        if type(i) == int:
            l2.append(i)
    return l2

#для локального запуска
test = [1,2,'a','b']
print("[1, 2, a, b] =>", end = " ")
print(filter_list(test))
input()