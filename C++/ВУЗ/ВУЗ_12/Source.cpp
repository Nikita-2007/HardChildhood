#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    int n, r = 1;
    cout << "������� �����:" << endl;
    cin >> n;

    for (int i = 1; i < n+1; i++) {
        r *= i;
    }

    cout << "��������� ������ �����: " << r << endl;

    system("pause>nul");
    return 0;
}