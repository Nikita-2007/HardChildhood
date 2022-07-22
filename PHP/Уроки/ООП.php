<?php
//ООП
namespace levens;
define('SIZE', 1920); #Константа

class Unit {
    const PI = 3.141592653589793;
    public $name;
    private $life;
    protected $pos;
    
    public function __construct($name, $life = 100) {
        $this -> name = $name;
        $this -> life = $life;
        $this -> pos = 200;
    }

    public function getLife($pas) {
        echo self::PI, '<br/>';
        if ($pas == '123456')
            return $this -> life;
        else
            return 0;
    }
}

echo Unit::PI;
echo '<br/>';
$unit = new Unit('Leon', 85);
echo $unit -> name, '<br/>';
#echo $unit -> life, '<br/>'; Ошибка доступа
echo $unit -> getLife(123456, '<br/><br/>');

class Hero extends Unit {
    public static $color = 'Black';
    public $armor;

    public function __construct($name, $life) {
        parent:: __construct($name, $life);
        $this -> armor = 286;
    }

    public function getPos() {
        echo parent::PI, '<br/>';; #self Тоже работает
        return $this -> pos;
    }

    public function __get($name) {
        return $this -> name;
    }

    public function __set($name, $value) {
        $this -> $name = $value;
    }
}
echo '<br/>', Hero::$color, '<br/>';
$hero = new Hero('Ranel', 55);
echo $hero -> armor, '<br/>';
#echo $hero -> pos; Нет доступа
echo $hero -> getPos(), '<br/>';
#Геттеры и сеттеры

/*

, '<br/>';

*/