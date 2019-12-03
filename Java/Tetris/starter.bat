@echo off
chcp 1251 >nul
title Kompilator :)
mode con cols=32 lines=16
color 0a

echo %TIME% - compilation
"C:\Program Files\Java\jdk-13.0.1\bin\javac.exe" Tetris.java

echo %TIME% - start
"C:\Program Files\Java\jdk-13.0.1\bin\java.exe" Tetris

pause >nul