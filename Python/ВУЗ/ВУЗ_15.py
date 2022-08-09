import random

print("Здравствуйте!")
print("Вы играите в игру 'Больше-меньше'.")
print("Здесь надо угодать число от 1 до 100.")
print("Вас будут держать в курсе - больше число или меньше.")
print("Удачи!")

while True:
	n = random.randint(1, 100)
	for i in range(5):
		print("Введите число: ")
		x = int(input())
		if (x == n):
			print("Поздравляю! Вы угадали")
			break
		elif (x > n):
			print("Загаданное число меньше")
		elif (x < n):
			print("Загаданное число больше")
			
	if (n != x):
		print("Вы проиграли. Было загадано:", n)
			

	print("Хотите начать сначала? (1 - ДА )")
	t = int(input())

	if (t != 1):
		break
