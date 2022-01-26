--26,01,2022
--[[
Многостроынй
коментарий
]]
os.setlocale('rus_rus.1251')
io.write('Привет')
print("Привет мир")
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

--Смена знаений
print(y, x) --Отступ
x, y = y, x
print(x..y) --Без пробелов(Контоканация(Склеивание сток())

--Присваивание разных значений разным переменым в 1 строчке
a, b, c = 5, 10, 20
print(a, b, c)

x = io.read('*n')