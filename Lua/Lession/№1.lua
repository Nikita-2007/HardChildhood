--26,01,2022
--[[
������������
����������
]]
os.setlocale('rus_rus.1251')
io.write('������') --������ �������
print("������ ���") --��������� � �������
print([[
������
���
]])

x = 123
print(x)
print(type(x))
print(type('x'))
print(type(print))
print(type(true))
print(type(nil))

--� �����
y = '5' --������ ������ ���������(�� ��������)
print(y)
print(type(y))
y = tonumber(y)
print(y)
print(type(y))

--� ������
y = 5 --����� ������������ � �����
print(y)
print(type(y))
y = tostring(y)
print(y)
print(type(y))

--����� �������
print(y, x) --������
x, y = y, x
print(x..y) --��� ��������(������������(���������� ����())

--������������ ������ �������� ������ ��������� � 1 �������
a, b, c = 5, 10, 20
print(a, b, c)

print(5^2)-- '^' - ���������� � �������

x = io.read('*n')