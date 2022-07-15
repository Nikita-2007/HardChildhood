<?php
//Функции

function func1() {
    echo "Всем привет", '<br/><br/>';
}
func1();

function func2($x) {
    echo $x, '<br/>';
}
func2("Всем привет");

function func3($x) {
    return $x*2;
    echo 'Не раотает после return';
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

$x = fn() => 7+8;
echo $x();