n, s, r = int(input("Введите число: ")), 1, 1
if (n < 0 or n > 1e15):
	print("Некоректные данные")
else:
	for i in range(n):
		if (n >= r * 2):
			r *= 2;
			s+=1
		else:
			break
	print("Степень двойки:", s)
