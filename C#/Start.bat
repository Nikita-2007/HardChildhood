@echo off
chcp 1251 >nul
title Kompilator :)
mode con cols=32 lines=16
color 0a

echo %TIME% - compilation
"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe" HelloWorld.cs