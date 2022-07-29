<?php
//Функции

function func1() {
    echo "Всем привет", '<br/><br/>';
}
func1();

function func2($x) {
    global $z;
    $z = 123;
    echo $x, '<br/>';
}
func2("Всем привет");
echo $z;

function func3($x) {
    return $x*2;
    echo 'Не работает после return';
}
echo func3(5), '<br/>';

function func4($x = 15) {
    return $x*2;
}
echo func4(10), '<br/>';

function func5(string $x) {
    return $x*2;
}
var_dump(func5(7)) ;
echo '<br/>';

$f = function($x) {
    echo $x, '<br/>';
};
$f("Анонимная функция <br/>");
//Импорт других данных
$y = 'Строка';
$f2 = function() use($y) {
    echo $y, '<br/>';
};
$f2();

$x = fn() => 7+8;
echo $x(),'<br/>';

#Гениратор yield
echo '<br/>Гениратор yield<br/>';
function func6() {
    yield 1;
    yield 2;
    yield from [3, 4];
    yield from new ArrayIterator([5, 6]);
    yield from func7();
    yield 9;
    yield 10;
}

function func7() {
    yield 7;
    yield from func8();
}
function func8() {
    yield 8;
}
#Вызов
foreach(func6() as $x) {
    echo $x, ' ';
}

