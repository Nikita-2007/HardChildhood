#include <iostream>

using namespace std;

int main() {
	setlocale(LC_ALL, "RUS");
	int A, B, C = 0;
	cout << "������ ��������� � � � � ��������������(� �� ��������������) ��������� ����������"<< endl;
	cout << "������� ����� �: ";
	cin >> A;
	cout << "������� ����� �: ";
	cin >> B;
	C = A;
	A = B;
	B = C;
	cout << "������ ��������� � � � � �������������� ��������� ����������" << endl;
	cout << "A = " << A << ", B = "  << B << endl;
	A ^= B ^= A ^= B;
	cout << "������ ��������� � � � ��� ������������� ��������� ����������" << endl;
	cout << "A = " << A << ", B = " << B << endl;
	return 0;
}