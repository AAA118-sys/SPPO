
#include <iostream>
#include "Windows.h"
#include <cmath>

using namespace std;

double f1(int x)
{
	double r = 0;
	if (x >= 0) {
		r = pow(2, -x) + 7 * x;;
	}
	else {
		r = x / 2 + 9;
	}
	return r;
}

int main()
{
	setlocale(LC_ALL, "rus");
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	double m, n, y;
	cout << "Введите первое значение";
	cin >> m;
	cout << "Введите количество";
	cin >> n;
	cout << "Введите шаг";
	cin >> y;

	for (int i = 1; i < n; i++, m += y)
	{
		double h = f1(m);
		cout << "i=" << m << ";f1(i)=" << h << endl;
	}
	system("pause");
	return 0;
}
