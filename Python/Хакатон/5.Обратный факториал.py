M = int(input())
N = 1
for i in range(48):
    N = N * (i+1)
    if N == M:
        N = i+1
        break
print(N)