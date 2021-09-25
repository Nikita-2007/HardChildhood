temp1 = temp2 = 1
 
N = int(input()) 
for i in range(2, N+1):
    temp1, temp2 = temp2, temp1 + temp2
print(temp2)
