echo off
chcp 1251>nul
:1
cls
set /p X=Ведите длину стороны трекгольника: 
if %X%==0 (goto 1)
if %X%==1 (goto 2)
if %X%==2 (goto 3)
echo:
for /L %%N in (1,1,%X%) do <nul set /p =@
echo:
for /L %%N in (4,1,%X%) do (
	<nul set /p =@
	for /L %%N in (%X%,-1,%%N) do <nul set /p =.
	echo @
	)
:3
echo @@
:2
echo @
pause>nul
goto 1