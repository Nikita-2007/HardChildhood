<?php
//Files
namespace files;
//Подключить файл
require "Функции.php";//Незаменимый
//include "ъ.php";//Подключение необязательного файла
//Одноразовое подключение
require_once "Циклы.php";
//include_once "ь.outdap";
//Автозагроузка файлов
function autoLoader($class) {
    echo "Подключение класса $class <br/>";
    include_once $class.'.php';
}
#spl_autoload_register('autoLoader()');
#$x = new XClass();