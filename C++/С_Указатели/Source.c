#include<stdio.h>
#include<locale.h>

int main(void)
{
	setlocale(LC_ALL, "rus");
	int x = 125;
	printf("�������� x: %d \n", x);
	printf("����� ������: %p \n", &x);
	int* p = &x;
	printf("����� ���������: %p \n", p);
	printf("�������� ���������: %d \n", *p);
	p++;
	printf("������� �� ������: %p \n", p);
	printf("�������� �������: %d \n", p);

	system("pause>nul");
	return 0;
}