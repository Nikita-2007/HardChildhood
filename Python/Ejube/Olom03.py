N, H = map(int, input().split())
arr = list(map(int, input().split()))

x = 0
for i in range(N):
    if x < arr.count(arr[i]):
        x = arr.count(arr[i])
if x < H:
    leng = H - x
elif x >= H:
    leng = 0

print(leng)