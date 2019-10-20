// Игра Больше меньше
//автор Никита Покидько
// 11.08.2018 Крым Саки
#include <iostream>
#include <ctime>
using namespace  std;
void main()
{
	setlocale(LC_ALL, "RUS");
	//Создание рандомного числа
	srand(time(NULL));
	int Z;
	int H=0;
	Z = rand() % 1000 + 1;
	//Знакомство с програмой
	cout << "Здравствуйте!\n";
	cout << "Вы играите в игру Больше меньше.\n";
	cout << "Сдесь надо угодать число от 1 до 1000\n";
	cout << "Вам будут подсказывать больше число или меньше\n";
	cout << "Удачи!";
	system("pause>nul");
start:
	system("cls");

	H++;
	//Запрос числа
	cout << "Введите число : ";
	int X;
	cin >> X;
	//Сравнение
	if (X == Z)
	{
	system("cls");
	cout << "Вы победили!\n";
	cout << "Число попыток: ";
	cout << H ;
	cout << " \n";
	cout << "Сыграть ещё раз? (Enter)";
	}
	if (X &rt Z)
	{
	system("cls");
		cout << "Число меньше";
	}
	if (X < Z)
	{
		system("cls");
		cout << "Число больше\n";
	}
	//вначало
	system("pause>nul");
goto start;
}

	