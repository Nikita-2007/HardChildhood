--26,01,2022
os.setlocale('rus_rus.1251')

x = io.read('*n')
if x == 0 then --����
	print('x = 0')
elseif x > 0 and (x ~= 5 or x < 5) then --����� ���� (~= ��� �� �����)
	print('0 < x < 5')
else -- �����
	print('x > 5')
end --��������� ������� ����� � �����������

do --���� ����
c = math.max(43, 45, 42, 1, -100)
end
print(c)

function sum(a, b) --�������
local c = a + b --��������� ��������� �������
return c --���������� ��������(� ���� ������ ���� �������� x = sum(a, b), �� x ����� = c)
end

print(sum(x, 10))
print(c)

multi = function(a, b)
local c  = a * b
return c
end

print(multi(x, 6))

x = io.read('*n')