#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int s, l1, r1, l2, r2, x1, x2;

    cout << "Введите значение чисел(s1, l1, r1, l2, r2):" << endl;

    cin >> s >> l1 >> r1 >> l2 >> r2;
    if (1e15 <= abs(s) || 1e15 <= abs(l1) || 1e15 <= abs(r1) || 1e15 <= abs(l2) || 1e15 <= abs(r2) || l1 >= r1 || l2 >= r2) {
        cout << "Некоректные данные" << endl;
        system("pause>nul");
        return 0;
    }

    if (l1 + l2 <= s && r1 + r2 >= s)
    {
        if (s - l1 <= r2) {
            x1 = l1;
            x2 = s - x1;
        }
        else {
            x2 = r2;
            x1 = s - x2;
        }
        cout << x1 << " " << x2 << endl;
    }
    else
        cout << -1 << endl;

    system("pause>nul");
    return 0;
}