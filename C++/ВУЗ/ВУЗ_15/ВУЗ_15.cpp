#include <iostream>

using namespace std;

int main()
{
    setlocale(LC_ALL, "rus");
    srand(time(NULL));
    int n, x, t;
    cout << "Здравствуйте!" << endl;
    cout << "Вы играите в игру 'Больше-меньше'." << endl;
    cout << "Здесь надо угодать число от 1 до 100." << endl;
    cout << "Вас будут держать в курсе - больше число или меньше." << endl;
    cout << "Удачи!" << endl;

len:
    n = rand() % 100 + 1;
    for (int i = 0; i < 5; i++) {
        cout << "Введите число: " << endl;
        cin >> x;
        if (x == n) {
            cout << "Поздравляю! Вы угадали" << endl;
            break;
        }
        else if (x > n)
            cout << "Загаданное число меньше" << endl;
        else if (x < n)
            cout << "Загаданное число больше" << endl;
    }
        if (n != x)
            cout << "Вы проиграли. Было загадано:" << n << endl;
            

    cout << "Хотите начать сначала? (1 - ДА )" << endl;
    cin >> t;

    if (t==1)
        goto len;

    system("pause>nul");
    return 0;
}