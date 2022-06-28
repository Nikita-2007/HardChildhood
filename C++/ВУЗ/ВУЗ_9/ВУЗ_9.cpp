#include <iostream>

using namespace std;

int main()
{
    int h1, h2, m1, m2, d;
    char t;
    setlocale(LC_ALL, "rus");
    label:
    cout << "Введите время прихода первого человека:" << endl;
    cin >> h1 >> t >> m1;
    cout << "Введите время прихода второго человека:" << endl;
    cin >> h2 >> t >> m2;
    if (h1 < 0 || h2 < 0 || h1>23 || h2>23 || m1 < 0 || m2 < 0 || m1>59 || m2>59)
    {
        cout << "Данные некоректны" << endl;
        system("pause>nul");
        return 0;
    }
    d = abs((h1 * 60 + m1) - (h2 * 60 + m2));
    cout << d << endl;
    if (d < 15 || d > 1425)
        cout << "Встреча состоится" << endl;
    else
        cout << "Встреча не состоится" << endl;
    goto label;

    system("pause>nul");
    return 0;
}