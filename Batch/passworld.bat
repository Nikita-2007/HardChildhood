@echo off
chcp 1251
cls
:1
set /p pass=Веддите пороль:
if %pass%==123456789 (goto 2) else (echo Неправильный пороль. Попробуйте ещё раз && goto 1)
:2
cls
echo Пароль Верный.
pause>nul