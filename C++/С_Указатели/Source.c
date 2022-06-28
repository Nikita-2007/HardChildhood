#include<stdio.h>
#include<locale.h>

int main(void)
{
	setlocale(LC_ALL, "rus");
	int x = 125;
	printf("Значение x: %d \n", x);
	printf("Адрес памяти: %p \n", &x);
	int* p = &x;
	printf("Адрес указателя: %p \n", p);
	printf("Значение указателя: %d \n", *p);
	p++;
	printf("Переход по памяти: %p \n", p);
	printf("Значение переход: %d \n", p);

	system("pause>nul");
	return 0;
}