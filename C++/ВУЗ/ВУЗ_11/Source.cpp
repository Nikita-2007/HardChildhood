#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int n, p, t;
    cout << "¬ведите основание степени" << endl;
    cin >> n;
    cout << "¬ведите показатель степени" << endl;
    cin >> p;

    t = n;
    for (int i = 1; i < p; i++) {
        n *= t;
    }

    cout << n << endl;

    system("pause>nul");
    return 0;
}