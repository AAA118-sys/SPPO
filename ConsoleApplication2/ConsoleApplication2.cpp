
#include<math.h>
#include<iostream>
using namespace std;

float F1(int x)
{
	float result = 0;

	if (x >= 0)
	{
		result = pow(2, -x) + 7 * x;
	}
	else
	{
		result = x / 2 + 9;
	}

	return result;
}

void F2(int& x)
{
	x = F1(x);
}

int main()
{
	setlocale(LC_ALL, "rus");

	float m, n, y;
	cout << "Введите первое значение";
	cin >> m;
	cout << "Введите количество";
	cin >> n;
	cout << "Введите шаг";
	cin >> y;

	for (int i = 1; i < n; i++, m += y)
	{
		float h = F1(m);
		cout << "i=" << m << ";F1(i)=" << h << endl;
	}
	cout << endl;

	for (int i = 1; i < n; i++, m += y)
	{
		cout << " i = " << i << " ; ";
		F2(i);
		cout << " i' = " << i << endl;
	}
	system("pause");
	return 0;
}
