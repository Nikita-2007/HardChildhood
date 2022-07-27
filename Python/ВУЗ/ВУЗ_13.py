n = int(input("Введите число: "))
if (n < 2 or n > 1e9):
	print("Некоректные данные")
else:
	for i in range(2, int(n ** (0.5))):
		if n % i == 0:
			print("Составное")
			t = 0
			break
		else:
			t = 1
	if (t == 1):
		print("Простое")
