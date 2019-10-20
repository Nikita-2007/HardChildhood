echo off
chcp 1251
title Текст
:1
cls
set /p S=Видите слово:  
echo:
echo Ваше слово:%S%
echo:

echo Первая буква вашего слова
echo %S:~0,1%
pause>nul

echo:
echo последние 3 буквы:
echo %S:~-3%
pause>nul

echo:
echo Всё слово кроме первыз 2 букв:
echo %S:~2%
pause>nul

echo:
echo Три третих букв
echo %S:~2,3%
pause>nul

echo:
echo Удаление части строки
echo %S:бар=%
pause>nul

echo:
echo Замена части строки
echo %S:бар=%___%
pause>nul
goto 1