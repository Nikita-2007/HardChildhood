--27,01,2022
os.setlocale('rus_rus.1251')

--math - матиматическая билитотека
--os - библиотека операционной системы
--string - библиотека строк
--table - библиотека коллекций

print(string.upper('aaaBBB')) --Делает все символы Большими
print(string.lower('aaaBBB')) --Делает все символы мальнькими
print(string.gsub('azaaazazazaz', 'z', 'x', 3)) --замена символов в строке
print(string.find("Hello World", 'lo', 1)) --Поиск стоки в строке, возращает позиции найденых
print(string.reverse('abcde')) --переворот строки
print(string.format('Год: %d', 2022)) --при выводе заменяет все %d на 2022
print(string.char(97, 98, 99, 100)) --вывод по смволам
print(string.byte('abcd')) --вывод кодировки символа(первого если не указывать)
print(string.len('aaaBBB')) --длина строки
print(string.rep('-=*=-', 10)) --Повторение строки указоное кол-во раз

print(math.random()) --рандом от 0 до 1
print(math.random(100)) --рандом от 0 до 100
print(math.random(30, 40)) --рандом от 30 до 40

arr = {2, 8, 42, 24, 1024, 18000000, 123, 'слова', 'слова', true} --создание "массива"(таблицы)
print(arr[6]) --позиция массива
print(#arr) --длина масссива
arr2 = {pn = "Понедельник", vt = "Вторник", sr = "Среда", ch = 'Четверг', py = 'Пятница', sy = 'Суббота', vo = 'Воскресенье'}
print(arr2.sr, arr2.py..arr2.pn) --вывод по значениям
table.sort(arr2) --сортировка массива
metaArr = {}
setmetatable(arr, metaArr) --множество для массива

x = io.read('*n')