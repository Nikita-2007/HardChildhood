<?php
//Http
echo "<h3>Протокол HTTP</h3>";
echo "<h4>GET запросы</h4>";

//http://localhost:3000/Http.php?x=12345
$x = "Неизвестно";
echo $x, '<br/>';
if (isset($_GET['x'])){
    echo "Передача значеня", '<br/>';
    $x = $_GET['x'];
    echo "Принято из строки браузера: ", $x, '<br/>';
}

//http://localhost:3000/Http.php?x=Hello&y=World
$x = "Hello";
echo $x, '<br/>';
if (isset($_GET['x']) && isset($_GET['y'])){
    echo "Передача нескольких значений", '<br/>';
    $x = $_GET['x'];
    $y = $_GET['y'];
    echo "Принято из строки браузера: ", $x, $y, '<br/>';
}

echo "GEТ запрос из клика по ссылке", '<br/><br/>';
echo '<a href="http://localhost:3000/Http.php?x=Нажата&y=Ссылка">Ссылка с влоденным GET запросом</a><br/><br/>';

echo "GЕT запрос с решением кнопки";
?><form>
<a href="http://localhost:3000/Http.php?x=Нажата&y=Кнопка">
<input type='button' value="Кнопка с GEТ запрсом">
</a>
</form><br/><br/><?php

echo "GET запрос с полем для ввода";
?><form method="GET" action="http://localhost:3000/Http.php">
Введите ваше имя:
<input type='text' name="y">
<input type="submit" name="x" value="Привет"/>
</form><br/><br/><?php

//Вывод даннных
echo "<h5>Данные в массиве _GET</h5>";
var_export($_GET);
echo '<br/>';

echo "<h5>Все данные в GLOBALS</h5>";
var_export($GLOBALS);
echo '<br/>';

/*

, '<br/>';

*/