@echo off      
chcp 1251
:1
cls
set /p pass=Ведите число:
echo Вы выбрали:%pass%
pause>nul
goto 1
