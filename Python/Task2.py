# Task 2
import random
r = random.randint(0, 1000)
print('Я задумал число, угодай его \n')
print(r)
y = 0
while y != 1:
    x = int(input())
    if x > r:
        print('Число Меньше')
    elif x < r:
        print('Число Больше')
    else:
        print('Вы угодали число')
        y = 1
input()