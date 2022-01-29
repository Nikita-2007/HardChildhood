--26,01,2022
--[[
Многостроынй
коментарий
]]
os.setlocale('rus_rus.1251')
io.write('Привет') --Просто выводит
print("Привет мир") --Стрингует и выводит
print([[
Привет
Мир
]])

x = 123
print(x)
print(type(x))
print(type('x'))
print(type(print))
print(type(true))
print(type(nil))

--В число
y = '5' --Строки всегда константы(не меняются)
print(y)
print(type(y))
y = tonumber(y)
print(y)
print(type(y))

--В строку
y = 5 --Число превращается в троку
print(y)
print(type(y))
y = tostring(y)
print(y)
print(type(y))

--Смена значний
print(y, x) --Отступ
x, y = y, x
print(x..y) --Без пробелов(Контоканация(Склеивание сток())

--Присваивание разных значений разным переменым в 1 строчке
a, b, c = 5, 10, 20
print(a, b, c)

print(5^2)-- '^' - возведение в степень

x = io.read('*n')