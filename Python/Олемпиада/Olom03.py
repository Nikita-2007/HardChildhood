def Photo(z, y, x):
    x = list(x)
    for i in x:
        print(i, end = "  ")
        a = x.count(i)
    return a

print(Photo(10, 7, "1 3 6 4 3 2 9"))
input()