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
(binary)
*/

//Код html(код PHP(код html(код js)))
echo ('<script>console.log("from php with love")</script>');

//Код html(код js)
?> <script>console.log("from php with love 2")</script><?php

echo '<br/>';
$x = 5;
$y = $x;
echo 'x и y = ', $x, ' ', $y, '<br/>';
$x = 111;
echo 'x и y = ', $x, ' ', $y, '<br/>';

echo 'Передача по ссылке', '<br/>';
$x = 5;
$y = &$x;
echo 'x и y = ', $x, ' ', $y, '<br/>';
$x = 111;
echo 'x и y = ', $x, ' ', $y, '<br/>';
echo '<br/>';

$ZZZ = 'Колдунство с переменной';
$x = 'ZZZ'; //Это стрка
echo $x, '<br/>';
echo $$x, '<br/>';
echo '<br/>';

$a = 'Hello';
$$a = ' World';
echo $a, $$a, '<br/>';
echo "$a ${$a}", '<br/>';
echo "$a  $Hello ", '<br/>';
echo '<br/>';

echo 2+2, ' ', 3-4, ' ', 4*3, ' ', 8/4, ' ', 100 % 24, '<br/>';
echo abs(-123), '<br/>';
echo min(29, 30, 4, 45), '<br/>';
echo max(29, 30, 4, 45), '<br/>';
echo pow(5, 2), '<br/>';
echo sqrt(16), '<br/>';
echo rand(10, 20), '<br/>';
echo mt_rand(10, 20), '<br/>'; //Более коректный алгоритм
echo 'floor: ', floor(5.9), '<br/>'; //Отбрость дробную часть
echo 'ceil: ', ceil(5.1), '<br/>'; //Округление в большую сторону
echo 'round: ', round(5.5), '<br/>'; //Округление
echo 'Число Пи: ', M_PI, '<br/>';
echo 'Число Е: ', M_E, '<br/>';
echo '<br/>';

$x = 10;
$y = $x++;
echo 'x++: ', $x, ' ', $y, '<br/>';
$x = 10;
$y = ++$x;
echo '++x: ', $x, ' ', $y, '<br/>';
$x = 10;
$y = $x--;
echo 'x--: ', $x, ' ', $y, '<br/>';
$x = 10;
$y = --$x;
echo '--x: ', $x, ' ', $y, '<br/>';

echo date('d.m.Y H:e'), '<br/>';

echo 2+'2', '<br/>';
echo '2'+'2', '<br/>';
echo 2+true, '<br/>';
echo '2'*False, '<br/>';
$x = false;
echo 'empty: ', empty($x), '<br/>';
echo 'isset: ', isset($x), '<br/>';
$x;
echo 'empty: ', empty($x), '<br/>';
echo 'isset: ', isset($x), '<br/>';

$x = 1;
echo 'empty: ', empty($x), '<br/>';
echo 'isset: ', isset($x), '<br/>';

$x = 0;
echo 'empty: ', empty($x), '<br/>';
echo 'isset: ', isset($x), '<br/>';

$x = null;
echo 'empty: ', empty($x), '<br/>';
echo 'isset: ', isset($x), '<br/>';

echo strlen('Hello'), '<br/>';
echo trim('   Hello    World        '), '<br/>';
echo strtoupper('Hello'), '<br/>';
echo strtolower('Hello'), '<br/>';
echo 'Хеширование - Hello: ', md5('Hello'), '<br/>';
echo 'Хеширование - 0: ', md5(0), '<br/>';
echo 'Хеширование - Много текста: ', md5('Всем привет, сегодня 25 июня 2022 года и уже закончился завтрак. Всем пока'), '<br/>';
echo 'phpinfo: ', phpinfo(), '<br/>';