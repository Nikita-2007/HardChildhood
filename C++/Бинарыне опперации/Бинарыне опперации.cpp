#include <iostream>
#include <bitset>
using namespace std;

int main()
{
    setlocale(LC_ALL, "RUS");

    cout << "Бинорное значение" << endl;
    int x = 0b0011;
    int y = 0x5;
    int z;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;

    cout << endl << "Бинорное НЕ" << endl;
    x = ~x;
    y = ~y;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;

    cout << endl << "Бинорное И" << endl;
    x = 3, y = 5;
    z = x & y;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;
    cout << "z равно: " << z << ", бинарно: " << bitset<8>(z) << endl;

    cout << endl << "Бинорное ИЛИ" << endl;
    z = x | y;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;
    cout << "z равно: " << z << ", бинарно: " << bitset<8>(z) << endl;

    cout << endl << "Бинорное исключающие ИЛИ(ЛИБО)" << endl;
    z = x ^ y;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;
    cout << "z равно: " << z << ", бинарно: " << bitset<8>(z) << endl;

    cout << endl << "Побитовый сдвиг на шаг в левво" << endl;
    y = x >> 1;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;

    cout << endl << "Побитовый сдвиг на шаг в право" << endl;
    y = x << 1;
    cout << "x равно: " << x << ", бинарно: " << bitset<8>(x) << endl;
    cout << "y равно: " << y << ", бинарно: " << bitset<8>(y) << endl;

    cout << endl << (x &= 5) << endl;

    system("pause>nul");
    return 0;
}