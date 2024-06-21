x, y = map(int, input().split())
row, col = map(int, input().split())
n = 0
res = '?'
arr = []
wave = [[x, y]]
for i in range(row):
	arr.append(list(input()))
arr[x][y] = n
while res == '?':
	if len(wave) == 0:
		res = 'NO'
	n += 1
	for i in range(len(wave)):
		if arr[wave[0][0]+1][wave[0][1]] == 'E':
			res = 'YES'
		elif arr[wave[0][0]+1][wave[0][1]] == ' ':
			arr[wave[0][0]+1][wave[0][1]] = n
			wave.append([wave[0][0]+1, wave[0][1]])
		if arr[wave[0][0]-1][wave[0][1]] == 'E':
			res = 'YES'
		elif arr[wave[0][0]-1][wave[0][1]] == ' ':
			arr[wave[0][0]-1][wave[0][1]] = n
			wave.append([wave[0][0]-1, wave[0][1]])
		if arr[wave[0][0]][wave[0][1]+1] == 'E':
			res = 'YES'
		elif arr[wave[0][0]][wave[0][1]+1] == ' ':
			arr[wave[0][0]][wave[0][1]+1] = n
			wave.append([wave[0][0], wave[0][1]+1])
		if arr[wave[0][0]][wave[0][1]-1] == 'E':
			res = 'YES'
		elif arr[wave[0][0]][wave[0][1]-1] == ' ':
			arr[wave[0][0]][wave[0][1]-1] = n
			wave.append([wave[0][0], wave[0][1]-1])
		wave.pop(0)
print(res)
