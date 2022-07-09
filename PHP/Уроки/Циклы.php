<?php
//Циклы
$x = 10;

//Пока!
While($x > 0):
    $x--;
    //Переход на следующий цикл
    if ($x == 3)
        continue;
    //Прервать цикл
    if ($x == 1)
        break;
    echo $x, ' ';
    endwhile;
echo '<br/>';

//for
for($i = 0; $i < 10; $i++) {
    echo $i, ' ';
}
echo '<br/>';

//Цикл 2 счётчика
for ($i = 1000, $j = 7; $i > 0; $i-=$j)
echo $i, '-', $j, ' ';
echo '<br/>';

//Цикл без операций
for ($i = 0; $i < 15; print $i++.' ');
echo '<br/>';

//foreach
$arr = [11, 22, 33, 44, 55, 66, 77, 88, 99];
foreach($arr as $elem)
    echo $elem, ' ';
echo '<br/>';

//Именованный массив
$arr = ['a' => 10, 'b' => 20, 'c' => 30];
foreach($arr as $key => $elem)
    echo $key, '-', $elem, ' ';


/*

, '<br/>';

*/