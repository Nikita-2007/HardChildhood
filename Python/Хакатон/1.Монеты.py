N = int(input())
x = N//5
N = N - (N//5)*5
x = x + N//3
N = N - (N//3)*3
x = x + N
print(x)
