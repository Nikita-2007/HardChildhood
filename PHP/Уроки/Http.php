<?php
//Http
echo "<h3>Протокол HTTP</h3>";
echo "<h4>GET запросы</h4>";

//http://localhost:3000/Http.php?TEST
$x = "Неизвестно";
if (isset($_GET['x'])){
    $x = $_GET['x'];
    echo "Принято из строки браузера", $x, '<br/>';
}
var_export($_GET);

/*

, '<br/>';

*/