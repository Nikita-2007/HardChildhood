<?php //Проект казино
require_once "header.php";
?>

<!--Счетчик кликов через JS-->
<button type="button" class="button" onClick="JS_Click()">
    <output id="js_count">Счетчик JS: 0</output>
</button>
<br><hr><br>

<!--Счетчик кликов через PHP-->
<?php
$count = 0;
if (isset($_POST["php_count"]))
    $count = preg_replace('/[^0-9]/', '', $_POST["php_count"])+1;
?>
<form method="post">
    <input type="submit" class="button" name="php_count" value='<?='Счетчик PHP: '.$count ?>' >
</form>
<br><hr><br>

<?php
var_export($GLOBALS);
require_once "footer.php";
?>