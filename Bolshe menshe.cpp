// ���� ������ ������
//����� ������ ��������
// 11.08.2018 ���� ����
#include <iostream>
#include <ctime>
using namespace  std;
void main()
{
	setlocale(LC_ALL, "RUS");
	//�������� ���������� �����
	srand(time(NULL));
	int Z;
	int H=0;
	Z = rand() % 1000 + 1;
	//���������� � ���������
	cout << "������������!\n";
	cout << "�� ������� � ���� ������ ������.\n";
	cout << "����� ���� ������� ����� �� 1 �� 1000\n";
	cout << "��� ����� ������������ ������ ����� ��� ������\n";
	cout << "�����!";
	system("pause>nul");
start:
	system("cls");

	H++;
	//������ �����
	cout << "������� ����� : ";
	int X;
	cin >> X;
	//���������
	if (X == Z)
	{
	system("cls");
	cout << "�� ��������!\n";
	cout << "����� �������: ";
	cout << H ;
	cout << " \n";
	cout << "������� ��� ���? (Enter)";
	}
	if (X &rt Z)
	{
	system("cls");
		cout << "����� ������";
	}
	if (X < Z)
	{
		system("cls");
		cout << "����� ������\n";
	}
	//�������
	system("pause>nul");
goto start;
}

	