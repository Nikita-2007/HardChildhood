# Yrock 5

# Функция Main
def Main():
    Hello()
    Hello_name("Никита")
    Hello_name_pluse("Test")
    Hello_name_pluse()
    Name_age("Никита1,", 13)
    Name_age(13, "Никита2,")
    Name_age(name = "Никита3,", age = 13)
    Name_age(age = 13, name = "Никита4,")
    Summ(1, 2, 3, 4, 5 ,6 ,7, 7+1, 10-1)
    x = Summ_return(1, 2, 3, 4)
    Name, Age = Summ_return_mnogo()
    print(x)
    print("")
    print(Name, Age)
    print(Summ_return_mnogo())

# Обычная Функция
def Hello():
    print("Hello Word")
    print("")

# Функция с параметром
def Hello_name(x):
    print("Hello,", x)
    print("")

# Функция с параметром по умолчанию
def Hello_name_pluse(x = "пользователь"):
    print("Hello,", x)
    print("")

# Функция с именоваными параметрами
def Name_age(name, age):
    print("Имя:", name, "Возрост:", age)
    print("")
# Функция с множеством параметрами
def Summ(*params):
    S = 0
    for i in params: 
        S += i
    print("Сумма:", S)
    print("")

# Функция с возратом
def Summ_return(*params):
    S = 0
    for i in params:
        S += i
    return S

# Функция с несколькими возратоми
def Summ_return_mnogo():
    name = "Вова Путин"
    age = 67
    return name, age

Main()

input()