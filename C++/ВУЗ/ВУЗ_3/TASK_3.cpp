#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");
	int A, B = 0;
	cout << "Введите число А ";
	cin >> A;
	cout << "Введите число В ";
	cin >> B;
	cout << "A+B=" << A + B << endl;
	cout << "A-B=" << A - B << endl;
	cout << "A*B=" << A * B << endl;
	if (B != 0)
		cout << "A/B=" << A / B << endl;
	else
		cout << "Ошибка: Деление на 0";

	double C, D = 0;
	cout << "Введите число C ";
	cin >> C;
	cout << "Введите число D ";
	cin >> D;
	cout << "A+B=" << C + D << endl;
	cout << "A-B=" << C - D << endl;
	cout << "A*B=" << C * D << endl;
	if (D != 0)
		cout << "A/B=" << C / D << endl;
	else
		cout << "Ошибка: Деление на 0";

	int E = 0;
	double F = 0;
	cout << "Введите число E ";
	cin >> E;
	cout << "Введите число F ";
	cin >> F;
	cout << "A+B=" << E + F << endl;
	cout << "A-B=" << E - F << endl;
	cout << "A*B=" << E * F << endl;
	if (F != 0)
		cout << "A/B=" << E / F << endl;
	else
		cout << "Ошибка: Деление на 0" << endl;

	int G = 0;
	double J = 0;
	cout << "Введите число G ";
	cin >> G;
	cout << "Введите число J ";
	cin >> J;
	cout << "A+B=" << G + J << endl;
	cout << "A-B=" << G - J << endl;
	cout << "A*B=" << G * J << endl;
	if (J != 0)
		cout << "A/B=" << G / J << endl;
	else
		cout << "Ошибка: Деление на 0";

	system("pause>nul");
	return 0;
}