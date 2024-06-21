/*
SQLite 3
*/
.help	--Команды транслятора
.open Name.dt	--Создает или открывает базу данных 

--Создание таблицы SQL
CREATE TABLE `user`(
	`name` TEXT,
	`age` INTEGER
);

--Добовляем данные
INSERT INTO `user` VALUES('Никита', 48);

--Получение данных
SELECT * FROM `user`;

.mode --Отображение
	  line --Линии
	  column --Колонки
header on --Отображение заголовков