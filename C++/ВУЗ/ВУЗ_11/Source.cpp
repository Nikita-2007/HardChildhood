#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int n, p, t;
    cout << "������� ��������� �������" << endl;
    cin >> n;
    cout << "������� ���������� �������" << endl;
    cin >> p;

    t = n;
    for (int i = 1; i < p; i++) {
        n *= t;
    }

    cout << n << endl;

    system("pause>nul");
    return 0;
}