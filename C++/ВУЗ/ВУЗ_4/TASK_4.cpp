#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");
	int A, B, C = 0;
	cout << "Меняем значеиние А и В с использованием(и не использованием) временной переменной"<< endl;
	cout << "Введите число А: ";
	cin >> A;
	cout << "Введите число В: ";
	cin >> B;
	C = A;
	A = B;
	B = C;
	cout << "Меняем значеиние А и В с использованием временной переменной" << endl;
	cout << "A = " << A << ", B = "  << B << endl;
	A ^= B ^= A ^= B;
	cout << "Меняем значеиние А и В без использования временной переменной" << endl;
	cout << "A = " << A << ", B = " << B << endl;
	return 0;
}