n, s = int(input("Введите число: ")), 0
if (n < 0 or n > 1e15):
	print("Некоректные данные")
else:
	for i in range(n):
		if (n >= i * i):
			s+=1
		else:
			break
	print("Степень двойки:", s)
