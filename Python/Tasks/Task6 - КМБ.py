# Task 6
import math
import random
import os

nin = 0
pob = 0
por = 0

while 1 < 2:
    print("               _           _   ___________ ")
    print("               \\\         //  !           !")
    print("    ЖЖ          \\\       //   !           !")
    print("   ЖЖЖЖЖ         \\\     //    !           !")
    print("  ЖЖЖЖЖЖЖ         \\\   //     !           !")
    print(" ЖЖЖЖЖЖЖЖЖЖ        \\\ //      !           !")
    print("ЖЖЖЖЖЖЖЖЖЖЖЖ    OOOOO OOOOO   !           !")
    print("ЖЖЖЖЖЖЖЖЖЖЖЖ    O   O O   O   !           !")
    print(" ЖЖЖЖЖЖЖЖЖЖ     OOOOO OOOOO   !___________!")

    print("")

    h = int(input("Выбирите 1(Камень), 2(Ножницы) или 3(Бумага): "))
    b = random.randint(1, 3)

    if b == 1:
        print("Кампьютер выбрал - Камень")
    if b == 2:
        print("Кампьютер выбрал - Ножницы")
    if b == 3:
        print("Кампьютер выбрал - Бумага")
        
    if h == 1:
        print("Вы выбрали - Камень")
    if h == 2:
        print("Вы выбрали - Ножницы")
    if h == 3:
        print("Вы выбрали - Бумага")
    
    
    if h == b:
        print("Ничья")
        nin += 1
    elif h == 1 and b == 2:
        print("Победа")
        pob += 1
    elif h == 2 and b == 3:
        print("Победа")
        pob += 1
    elif h == 3 and b == 1:
        print("Победа")
        pob += 1
    else:
        print("Порожение")
        por += 1
    print("Ничьих:", nin)
    print("Порожений:", por)
    print("Побед:", pob)
    input("Нажмите любую клавишу, что бы начать заново...")
    os.system('cls||clear')