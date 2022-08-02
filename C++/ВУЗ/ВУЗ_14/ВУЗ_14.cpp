#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int n, s = 1, r = 1;
    cout << "Введите число:" << endl;
    cin >> n;
    if (n < 0 || n > 1e15) {
        cout << "Некоректные данные " << endl;
        system("pause>nul");
        return 0;
    }
    for (int i = 1; i < n; i++) {
        if (n >= r * 2) {
            r *= 2;
            s++;
        }
        else
            break;
    }
    cout << "Степень двойки: " << s << endl;
    system("pause>nul");
    return 0;
}