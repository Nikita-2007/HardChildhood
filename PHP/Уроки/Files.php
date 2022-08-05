<?php
//Files
namespace files;
//Подключить файл
require "Функции.php";//Незаменимый
//include "ъ.php";//Подключение необязательного файла
//Одноразовое подключение
require_once "ООП.php";
//include_once "ь.outdap";
//Автозагроузка файлов
function autoLoader($class) {
    echo "Подключение класса $class <br/>";
    include_once $class.'.php';
}
#spl_autoload_register('autoLoader()');
#$x = new XClass();

echo '<h3>Импорт пространства имён</h3>';
#$hero = new Hero('Vorh', 50); Не работает
$hero = new \lesens\Hero('Vorh', 50);
echo $hero -> name, '<br/>';

use \lesens\Hero; #Заранее подключить пространство имён
$hero2 = new Hero('Focel', 75);
echo $hero2 -> name, '<br/>';

use \lesens\Hero as Lh; #C псевданимом
$hero3 = new lh('Liron', 47);
echo $hero3 -> name, '<br/>';

//use \lesens\{Hero, Unit, SueprHero as Sh};

use const 
\lesens\TEST;
echo TEST, '<br/>';

#use function \lesens\*Имя фунции* - иморт функции

#Файловая система
#die = exit = exit() = exit(0); - Выход из скрипта, возможно сообщением об ошибке
$file = fopen('test.txt', 'w') or die('Не удолось открыть файл');
#'r': файл открывается только для чтения. Если файла не существует, возвращает false
#'r+': файл открывается только для чтения с возможностью записи. Если файла не существует, возвращает false
#'w': файл открывается для записи. Если такой файл уже существует, то он перезаписывается, если нет - то он создается
#'w+': файл открывается для записи с возможностью чтения. Если такой файл уже существует, то он перезаписывается, если нет - то он создается
#'a': файл открывается для записи. Если такой файл уже существует, то данные записываются в конец файла, а старые данные остаются. Если файл не существует, то он создается
#'a+': файл открывается для чтения и записи. Если файл уже существует, то данные дозаписываются в конец файла. Если файла нет, то он создается
fwrite($file, "Тестовая запись \r\n");#Запись файл
fwrite($file, "Ещё одна запись" . PHP_EOL);
fclose($file);

#Чтение файла
$file = fopen('test.txt', 'r') or die('Не удолось открыть файл');
while (!feof($file)) {
    $str = htmlentities(fgets($file));
    echo $str, '<br/>';
}
fclose($file);
echo '<br/>';

//Чтение файла полностью
$str = htmlentities(file_get_contents('test.txt'));
echo 'Файл целиком:', '<br/>';
echo $str, '<br/>';

//Создание папки
if (mkdir('NewFolder'))
    echo 'Каталог создан', '<br/>';
else
    echo 'Возникла ошибка', '<br/>';

//Где я?..
$path = getcwd();
echo $path, '<br/>';

//Копирвоание файла
if (copy('test.txt', 'test2.txt'))
    echo 'Файл скопирован', '<br/>';
else
    echo 'Возникла ошибка', '<br/>';

//Перенос файла
if (rename('test2.txt', 'NewFolder/test3.txt'))
echo 'Файл перемещён', '<br/>';
else
echo 'Возникла ошибка', '<br/>';

//Удаление файла
if (unlink('NewFolder/test3.txt'))
    echo 'Файл Удалён', '<br/>';
else
    echo 'Возникла ошибка', '<br/>';

//Удаление папки
if (rmdir('NewFolder'))
    echo 'Каталог удалён', '<br/>';
else
    echo 'Возникла ошибка', '<br/>';

//Открытие, чтение, и вывод содержимого папок
$dir = getcwd();
if (is_dir($dir))
    if ($temp = opendir($dir)) { //Открываем каталог
        while(($file = readdir($temp)) !== false) { //Считываем по одному
            if ($file == '.' || $file == '..') //Пропуск точек
                continue;
            if (is_dir($file))
                echo "Каталог: $file", '<br/>';
            else
                echo "Файл: $file", '<br/>';
        }
        closedir();
    }
    