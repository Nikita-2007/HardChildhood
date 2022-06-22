#include <iostream>
using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");

    double a, b;
    char x;
    cin >> a >> x >> b;

    if (x == '+')
        cout << a + b << endl;
    else if (x == '-')
        cout << a - b << endl;
    else if (x == '*')
        cout << a * b << endl;
    else if (x == '/')
        cout << a / b << endl;
    else
        cout << "Ошибачный ввод" << endl;

    system("pause>nul");
    return 0;
}