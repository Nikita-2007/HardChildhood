--27,01,2022
os.setlocale('rus_rus.1251')

--��������� ���� �������
x = 5
repeat
print('repeat - '..x)
x = x-1
until x < 0

print()
x = 0
--��������� �� �������
while x < 5 do
print('while - '..x)
x = x+1
end

print()

--��������� �� ������ ������
for i = 1, 5, 2 do
print('for - '..i)
end

print()

--���������
arr = {5, 10, 15, 20, 25}
for k, i in ipairs(arr) do
print('��������� - '..k..' '..i)
end

print()

--��������� �� ������ �������
for i = 1, #arr do
print(arr[i])
end

--������ �����:
--	dofile("�3.lua")
--	local module = require('�2')
x = io.read('*n')