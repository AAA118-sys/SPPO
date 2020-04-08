﻿#include <iostream>

using namespace std;

struct element {
	double value;
	element* pointer;
	element() {
		value = 0;
		pointer = NULL;
	}
};
void f1(element*& one, element*& two, int r) {
	element* p = one;
	element* l = NULL;
	int i = 1;
	while (i < r) {
		p = p->pointer;
		i++;
	}
	l = p->pointer;
	p->pointer = NULL;
	p = NULL;
	two = l;
}
void InputList(element*& one, int N) {
	element* p = NULL;
	int i = 0;
	cout << "Введите каждый элемент ";
	while (i < N) {
		element* p1 = new element();
		cin >> p1->value;
		if (one == NULL) {
			one = p1;
			p = p1;
		}
		else {
			p->pointer = p1;
			p = p1;
		}
		i++;
	}
}
void OutputList(element* l) {
	while (l != NULL) {
		cout << l->value << " ";
		l = l->pointer;
	}
	cout << endl;
}

int main() {
	setlocale(LC_ALL, "rus");

	element* first = NULL;
	element* second = NULL;
	int N, c;

	cout << "Введите длину списка ";
	cin >> N;

	InputList(first, N);
	OutputList(first);
	if (N % 2 == 0) {
		c = N / 2;
	}
	else {
		c = N / 2 + 1;
	}
	f1(first, second, c);
	OutputList(first);
	OutputList(second);

	system("pause");
	return 0;
}
