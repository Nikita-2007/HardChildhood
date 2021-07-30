N = int(input())

arrtoo = []
arr = list()
maxcount1 = '0'
maxcount2 = '0'

for i in range(N):
    arrtoo.append(list(input()))
    for j in range(N):
        arr.append(arrtoo[i][j])

for i in arr:
    if arr.count(maxcount1) < arr.count(i):
        maxcount1 = arr.count(i)
    if arr.count(maxcount2) < arr.count(i) and (arr.count(maxcount2) != maxcount1):
        maxcount2 = arr.count(i)
print(maxcount1, maxcount2)