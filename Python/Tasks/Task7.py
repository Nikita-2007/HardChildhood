arr2 = []
n = int(input())
for i in range(n):
	p = input()
	x = y = 0
	arr = [[x, y]]
	g = 1
	s = 'kiborg'
	for j in range(0, len(p)-1, 2):
		c = str(p[j]) + str(p[j+1])
		if c == '00':
			y -= 1
		elif c == '01':
			x += 1
		elif c == '10':
			x -= 1
		else:
			y += 1
		if [x, y] in arr:
			s = 'robot'
		else:
			g += 1
			arr.append([x, y])
	arr2.append([s, g])
for i in range(n):
	print(*arr2[i])
