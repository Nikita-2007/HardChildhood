#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");
	int A, B = 0;
	cout << "������� ����� � ";
	cin >> A;
	cout << "������� ����� � ";
	cin >> B;
	cout << "A+B=" << A + B << endl;
	cout << "A-B=" << A - B << endl;
	cout << "A*B=" << A * B << endl;
	if (B != 0)
		cout << "A/B=" << A / B << endl;
	else
		cout << "������: ������� �� 0";

	double C, D = 0;
	cout << "������� ����� C ";
	cin >> C;
	cout << "������� ����� D ";
	cin >> D;
	cout << "A+B=" << C + D << endl;
	cout << "A-B=" << C - D << endl;
	cout << "A*B=" << C * D << endl;
	if (D != 0)
		cout << "A/B=" << C / D << endl;
	else
		cout << "������: ������� �� 0";

	int E = 0;
	double F = 0;
	cout << "������� ����� E ";
	cin >> E;
	cout << "������� ����� F ";
	cin >> F;
	cout << "A+B=" << E + F << endl;
	cout << "A-B=" << E - F << endl;
	cout << "A*B=" << E * F << endl;
	if (F != 0)
		cout << "A/B=" << E / F << endl;
	else
		cout << "������: ������� �� 0" << endl;

	int G = 0;
	double J = 0;
	cout << "������� ����� G ";
	cin >> G;
	cout << "������� ����� J ";
	cin >> J;
	cout << "A+B=" << G + J << endl;
	cout << "A-B=" << G - J << endl;
	cout << "A*B=" << G * J << endl;
	if (J != 0)
		cout << "A/B=" << G / J << endl;
	else
		cout << "������: ������� �� 0";

	system("pause>nul");
	return 0;
}