--27,01,2022
os.setlocale('rus_rus.1251')

--math - �������������� ����������
--os - ���������� ������������ �������
--string - ���������� �����
--table - ���������� ���������

print(string.upper('aaaBBB')) --������ ��� ������� ��������
print(string.lower('aaaBBB')) --������ ��� ������� ����������
print(string.gsub('azaaazazazaz', 'z', 'x', 3)) --������ �������� � ������
print(string.find("Hello World", 'lo', 1)) --����� ����� � ������, ��������� ������� ��������
print(string.reverse('abcde')) --��������� ������
print(string.format('���: %d', 2022)) --��� ������ �������� ��� %d �� 2022
print(string.char(97, 98, 99, 100)) --����� �� �������
print(string.byte('abcd')) --����� ��������� �������(������� ���� �� ���������)
print(string.len('aaaBBB')) --����� ������
print(string.rep('-=*=-', 10)) --���������� ������ �������� ���-�� ���

print(math.random()) --������ �� 0 �� 1
print(math.random(100)) --������ �� 0 �� 100
print(math.random(30, 40)) --������ �� 30 �� 40

arr = {2, 8, 42, 24, 1024, 18000000, 123, '�����', '�����', true} --�������� "�������"(�������)
print(arr[6]) --������� �������
print(#arr) --����� ��������
arr2 = {pn = "�����������", vt = "�������", sr = "�����", ch = '�������', py = '�������', sy = '�������', vo = '�����������'}
print(arr2.sr, arr2.py..arr2.pn) --����� �� ���������
table.sort(arr2) --���������� �������
metaArr = {}
setmetatable(arr, metaArr) --��������� ��� �������

x = io.read('*n')