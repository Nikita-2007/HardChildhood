#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int n;
    cout << "Введите число:" << endl;
    cin >> n;
    if (n < 2 || n > 1e9) {
        cout << "Некоректные данные" << endl;
        system("pause>nul");
        return 0;
    }
    for (int i = 2; i <= sqrt(n); i++) {
        if (n % i == 0) {
            cout << "Составное" << endl;
            system("pause>nul");
            return 0;
        }
    }
    cout << "Простое" << endl;
    system("pause>nul");
    return 0;
}