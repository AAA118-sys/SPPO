﻿
#include<iostream>

using namespace std;

void F1(double*& mas, int& n)
{
	int n1 = n / 2 + n % 2;
	int n2 = n / 2;
	double* mas1 = new double[n1];

	int j = 0;
	for (int i = 0; i < n1; i++)
	{
		mas1[j] = mas[i];
		j++;
	}

	j = 0;
	double* mas2 = new double[n2];
	for (int i = n1; i < n; i++)
	{
		mas2[j] = mas[i];
		j++;
	}

	for (int i = 0; i < n1; i++)
	{
		cout << mas1[i] << " ";
	}
	cout << endl;
	for (int i = 0; i < n2; i++)
	{
		cout << mas2[i] << " ";
	}
}


int main()
{
	setlocale(LC_ALL, "");
	int n;
	cout << "Введите n" << endl;
	cin >> n;
	double* mas = new double[n];
	for (int i = 0; i < n; i++) {
		cin >> mas[i];
	}
	for (int i = 0; i < n; i++) {
		cout << mas[i] << " ";
	}
	cout << endl;
	F1(mas, n);
	system("pause");
	return 0;
}
