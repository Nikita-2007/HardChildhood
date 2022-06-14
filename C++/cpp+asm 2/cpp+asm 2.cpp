#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");

    int x;
    int y;
    int res;

    cin >> x;
    cin >> y;

    //Умножение
    __asm
    {
        mov eax, x
        mov ebx, y
        mul ebx
        mov res, eax
    }
    cout << res << endl;
    //Отнимание
    __asm
    {
        mov eax, x
        mov ebx, y
        sub eax, ebx
        mov res, eax
    }
    cout << res << endl;
    //Деление
    //__asm
    //{
    //    mov eax, x
    //    mov ebx, y
    //    div ebx
    //    mov res, eax
    //}
    //cout << res;
}