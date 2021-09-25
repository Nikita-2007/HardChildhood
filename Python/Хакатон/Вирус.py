arr = input()
arr2 = {}
for i in range(0, len(arr), 3):
    temp = (arr[i] + arr[i+1] + arr[i+2])
    C = arr.count(temp)
    arr2[tempp] = C
print(arr2)