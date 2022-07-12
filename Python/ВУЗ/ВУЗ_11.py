n = int(input("Введите основание степени: "))
t = n
for i in range(int(input("Введите показатель степени: "))-1): n *= t
print(n)
