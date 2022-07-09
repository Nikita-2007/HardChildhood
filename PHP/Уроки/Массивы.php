<?php
//Массивы
$arr = array(11, 22, 33, 44, 55, 66, 77, 88, 99);
//echo $arr, '<br/>'; - Не работает
echo $arr[2], '<br/>'; 
echo print_r($arr), '<br/>';
echo var_dump($arr), '<br/>';
echo var_export($arr), '<br/>';

$arr2 = ['Имя' => 'Адольф', 'Возраст' => 89, 'Класс' => '-3Ъ', 'Оценки' => [5, 3, 3, 4, 'Болел', 6], 'Ученик' => true];
echo var_dump($arr2), '<br/>';
echo var_dump($arr2['Класс']), '<br/>';
echo var_export($arr2), '<br/>';
echo var_export($arr2['Ученик']), '<br/>';
echo $arr2['Ученик'], '<br/>'; //Различие в выводе данных
echo var_dump($arr2['Ученик']), '<br/>';

$week = [1 => 'Пн', 'Вт', 'Ср', 'Чт', 'Пт', 'Сб']; //Автоиндексация
echo $week[3], '<br/>';
$week[] = 'Вс'; //Автодополнение
echo $week[7], '<br/>';

echo count($week), '<br/>';
sort($week); //По возрастанию
echo var_export($week), '<br/>';
asort($week); //По убыванию
echo var_export($week), '<br/>';