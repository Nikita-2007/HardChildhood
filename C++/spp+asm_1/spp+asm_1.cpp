﻿#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");

    int x;
    int y;
    int res;

    cin >> x;
    cin >> y;

    __asm
    {
        mov eax, x
        mov ebx, y
        add eax, ebx
        mov res, eax
    }

    cout << res;

    //Повторное использование данных
    cin >> x;
    __asm
    {
        mov eax, x
        add eax, ebx
        mov res, eax
    }
    cout << res;
}