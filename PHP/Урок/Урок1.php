Просто текст
<br>
<h1>Код html</h1>
<br>
<!--Коментарий html-->
<? print("HelloWorld") ?>

<?php
/*Основы php*/
echo '<br/>';
$x = 2;
echo $x, '<br/>'; //Выводит много значений
$x += 2.345; //Преобразует в float
print($x); //Выводитт 1 значение с return 1(true)
echo '<br/>';
print_r($x); //Форматирует в сторку
echo '<br/>';
var_dump($x); //Выводит с типом данных(длф отладки)
echo '<br/>';
var_export($x); //Вывод с формате сполняемого кода
echo '<br/>';
echo 'Контаканация $x' . "Склейка строк-$x"; // "" - строка '' - с переменными
$x = 'Кон';
echo '<br/>';
echo $x .= 'таканация';
$x = null; //null - отцуствие значения
echo '<br/>';
var_dump($x); // Единственный способ обозначить null
echo '<br/>';
echo (int)123.456, '<br/>'; //Отиновывание 
/*
Цифра:
(int)

Правда\Ложь:
(bull)

Цифры со значением после запятой:
(float)
(duble)
(real)
(string)

Массив:
(array)

Объект:
(object)

Нулл или удаление из памяти:
(unset)

Бинарный код:
(binary)*/

echo ('<script>console.log("from php with love")</script>');