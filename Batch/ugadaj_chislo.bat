@echo off
chcp 1251
:start
set /a RND=%random% %%1000 +1
set /a %GAME%+=1
:1
cls
set /a GAME=%GAME%+1
set /p X=Ведите Число: 
if %X% LSS %RND% (echo Число больше
	pause>nul
	goto 1
	)
if %X% GTR %RND% (echo Число меньше
	pause>nul
	goto 1
	)
if %X%==%RND% (
	echo Вы победили!!!.Вы угодали Число!!!
	echo С %GAME% Попытки 
	pause>nul
	set /a GAME=0
	goto satrt
	)