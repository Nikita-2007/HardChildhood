--27,01,2022
os.setlocale('rus_rus.1251')

--Повторяет пока условие
x = 5
repeat
print('repeat - '..x)
x = x-1
until x < 0

print()
x = 0
--Повторяет до условия
while x < 5 do
print('while - '..x)
x = x+1
end

print()

--Повторяет со сбором данных
for i = 1, 5, 2 do
print('for - '..i)
end

print()

--Иттератор
arr = {5, 10, 15, 20, 25}
for k, i in ipairs(arr) do
print('Итерратор - '..k..' '..i)
end

print()

--Повторяет до длинны массива
for i = 1, #arr do
print(arr[i])
end

--запуск файла:
--	dofile("№3.lua")
--	local module = require('№2')
x = io.read('*n')