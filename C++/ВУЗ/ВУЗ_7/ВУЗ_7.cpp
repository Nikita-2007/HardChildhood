#include <iostream>

using namespace std;

int main()
{
    int n;
    setlocale(LC_ALL, "rus");
    cout << "Введите способ решения:" << endl;
    cin >> n;
    if (n == 1) {
        double a, b, c, p, S;
        cout << "Введите длинну a" << endl;
        cin >> a;
        cout << "Введите длинну b" << endl;
        cin >> b;
        cout << "Введите длинну c" << endl;
        cin >> c;
        p = (a + b + c)/2;
        S = sqrt(p * (p - a) * (p - b) * (p - c));
        if (S > 0)
            cout << "S = " << S << endl;
        else
            cout << "Некорректные данные" << endl;
    }
    else if (n == 2) {
        double x1, x2, x3, y1, y2, y3, S;
        cout << "Введите коордитаны a" << endl;
        cin >> x1 >> y1;
        cout << "Введите коордитаны b" << endl;
        cin >> x2 >>  y2;
        cout << "Введите коордитаны c" << endl;
        cin >> x3 >> y3;
        S = abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2;
        if (S > 0)
            cout << "S = " << S << endl;
        else
            cout << "Некорректные данные" << endl;
    }
    else
        cout << "Ошибачный ввод" << endl;
    system("pause>nul");
    return 0;
}