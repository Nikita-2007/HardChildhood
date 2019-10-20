@echo off
chcp 1251
setlocal ENABLEDELAYEDEXPANSION
mode con cols=100 lines=40
cls
set X=1
:start
FOR /F "usebackq delims=" %%i IN (Sprate.txt) DO (
	echo.%%i
	set /a X=X+1
	if !X! gtr 39 (
		set X=1
		>nul pathping /h 1 /p 120 /q 1 /w 1 127.0.0.1
::pause >nul
		cls
		)
	)
goto start