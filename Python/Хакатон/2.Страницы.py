M = int(input())
N = 0
i=0
while True:
    i += 1
    N = N + len(str(i))
    print(i, N)
    if N == M:
        N = i
        break
print(N)