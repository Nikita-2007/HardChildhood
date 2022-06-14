#include <iostream>

using namespace std;

int main() {
    setlocale(LC_ALL, "RUS");
    double x, u, t;
    cout << "Введите x, u и t:" << endl;
    cin >> x >> u >> t;
    cout << "Ответ:" << x + u * t - (9.8 * t * t / 2);
    system("pause>nul");
    return 0;
}