<?php
//Поток
$x = 125 <=> 6; //Больше/Меньше/Равно. Возращает -1 0 1
echo $x, '<br/>';
if (5 > 3)
    echo "5 > 3", '<br/>';

if (1 === true)
    echo "1 === true по значению и по типу данных", '<br/>';
else
    echo "1 не === true по значению и по типу данных", '<br/>';

if (5 > 0 and 5 != 0 || true)  {
    echo "Много условий";
    echo '<br/>';
} else if (5 < 3 && (1 > 2 or 5 < 3))
    echo "Иначе если", '<br/>';
else
    echo "Просто иначе", '<br/>';

//Другой синтаксис(для скриптов)
if (20>10):
    echo "20 > 10", '<br/>';
elseif (20>0):
    echo "20 > 0", '<br/>';
else:
    echo "20 !> 10 и 20 !> 0", '<br/>';
endif;

//Тернарный синтаксис

echo 5>2 ? "Да" : 'Нет';
echo '<br/>';

$x = 7;
switch($x) {
    case 0:
        echo "x=0";
        break;
    case 1:
        echo "x=1";
        break;
    case 5:
        echo "x=5";
        break;
    case 10:
        echo "x=10";
        break;
    default:
        echo "Всё остольное", '<br/>';
    break;
}

match($x) {
    0 => print 'Да match x = 0',
    1 => print 'Да match x = 1',
    7 => print 'Да match x = 7',
    default => print "Всё остольное"
};