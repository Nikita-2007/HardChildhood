#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");

    int count, f = 1;

    cout << "Введи знаменатель факториала" << endl;
    cin >> count;

    //Возведение в факториал
    __asm
    {
        mov esi, 1
        mov eax, f
        label:     ;Метка для повтора
            mul esi
            inc esi
        cmp esi, count
        jng label   ;Крутимся в цыкле
        mov f, eax
    }
    cout << f << endl;
    system("pause>nul");
}