# Yrock 4

x = 0
while x < 10:
    x += 1
    print(x)
print("")

Game_over = False
while not Game_over:
    x += 1
    if x > 20:
        Game_over = True
    print(x)
print("")
    
# Циклы for: стоп, старт-стоп, старт-стоп-шаг
for i in range(5):
    print(i)
print("")
    
for i in range(10, 13):
    print(i)
print("")
    
for i in range(100, 200, 20):
    print(i)
print("")

x = [-10, -5, 20, 100, 5000]
print(x)
print(type(x))
for i in x:
    print(i)
print("")

for i in "Hello Word" :
    print(i)
print("")
    
#Цикл В Цикле

for i in range(2, 11):
    for j in range(2, 11):
        print(i * j, end = " ")
    print("")

input()