#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");

    double a, b, c;
    cout << "Введите числоа a" << endl;
    cin >> a;
    cout << "Введите числоа a" << endl;
    cin >> b;
    cout << "Введите числоа a" << endl;
    cin >> c;
    double D = b * b - 4 * a * c;
    if (D > 0 and a != 0) {
        cout << "x1=" << (-b + sqrt(D)) / (2 * a) << endl;
        cout << "x2=" << (-b - sqrt(D)) / (2 * a);
    }
    else if (D == 0)
        cout << "x=" << -b / (2 * a);
    else if (a == 0)
        cout << "x=" << -b / c;
    else
        cout << "Корнй нет т.к. Дискрименант меньше 0";

    system("pause>nul");
    return 0;
}