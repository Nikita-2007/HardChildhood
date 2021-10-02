#ДОРЕШИВАНРИЕ
N = int(input())
M = 0
L = 1
R = 1

while N > 0:
    S = R*L*9
    if N < S:
        M += N//L
        break
    else:
        M += S//L
        N -= S 
        R *= 10
        L += 1
print(M)
