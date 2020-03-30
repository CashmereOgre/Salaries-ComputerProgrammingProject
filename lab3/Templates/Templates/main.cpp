// task_lab3_templates.cpp : Ten plik zawiera funkcjê „main”. W nim rozpoczyna siê i koñczy wykonywanie programu.
//

#include <iostream>
#include<cmath>
using namespace std;

template<class one, class two>
one min(one a, two b)
{
	if (a < b)
		return a;
	else
		return b;
}

template<class one, class two>
two max(one a, two b)
{
	if (a < b)
		return b;
	else
		return a;
}


//exercise 1
/*
	Create template with 2 parameters
	create functions type1 min() and type2 max()
	thet compares two numbers for configurations:
	int - int;
	double - double;
	and returns the smallest/biggest number of type double and int


int main()
{
	//	1. Create 4 variables (2 integers and 2 doubles) and initialize them with some good testing values.
	//	2. call the functions min and max for types: <int , int>, <double , double>
	//	3. call function max (4 combinations) for types <int, double>, what is the return type ?
	//	4. call function min (4 combinations) for types <int, double> are the results correct ?
	//	5. change the return type to double (go back to point 4)

}
*/

template <class T>
class MathOperations {
	T first, second;
public:
	//write constructor with 2 parameters of type T
	MathOperations(T f, T s) 
	{
		first = f;
		second = s;
	}

	//write methods (methods should be compatibile with main )
	T add()
	{
		return first + second;
	}
	T subtract()
	{
		return first - second;
	}
	T multiply()
	{
		return first * second;
	}
	T divide()
	{
		return first / second;
	}
	T log()
	{
		return log2(first) / log2(second);
	}

};

/*
// task 2

template <class T>
class MathOperations {
	T first, second;
public:
	//write constructor with 2 parameters of type T
	MathOperations() {}

	//write methods (methods should be compatibile with main )
	add();
	subtract();
	multiply();
	divide();
	log();

};


void main()
{
	//Do not change main
	MathOperations<int> mathOperations(2,8);
	cout << mathOperations.add()<<endl;
	cout << mathOperations.subtract() << endl;
	cout << mathOperations.multiply() << endl;
	cout << mathOperations.divide() << endl<<endl;

	MathOperations<double> mathOperations1(66.6, 7.34);
	cout << mathOperations1.add() << endl;
	cout << mathOperations1.subtract() << endl;
	cout << mathOperations1.multiply() << endl;
	cout << mathOperations1.divide() << endl;
}
*/


/*Exercise 3
Create a class List representing a one - directional list template.
The layout parameter determines what type of data the list stores.
In a structured private field containing stored data and a pointer to the next element.
In the public field methods that allow you to:

- add an item
- sum all elements from the list
- return the number of items in a list
- delete all alements from the list

Then outside the class write the body of declared methods
*/

/*  Exercise 3
	Stworz klase Lista reprezentujaca szablon listy jednokierunkowej.
	Parametr szablonu okresla jaki typ danych przechowuje lista.
	W polu prywatnym utworzyc strukture zawierajaca przechowywana dane i wskaznik na nastepny element.
	W polu publicznym metody, które umozliwia dodanie elementu, usuniecie calej listy,
	zsumowanie wszystkich elementów listy i zwrócenie ilosci elementów, które lista zawiera.
*/
template <class type>
class List
{
private:
	struct Elem
	{
		type data;
		Elem* pNext;
	};

	Elem* head;

public:
	List();
	void add(type nowy);
	void del();
	type sum();
	int size();
	void print();
	~List();
};

template <class type> List<type>::List()
{
	head = nullptr;
}


template <class type> void List<type>::add(type nowy)
{
	if (head == nullptr)
	{
		head = new Elem;
		head->data = nowy;
		head->pNext = nullptr;
	}
	else
	{
		Elem* temp = head;
		while (temp->pNext != nullptr)
		{
			temp = temp->pNext;
		}
		temp->pNext = new Elem;
		temp->pNext->data = nowy;
		temp->pNext->pNext = nullptr;
	}
}

template <class type> void List<type>::del()
{
	Elem* tmp = head;

	while (head != nullptr)
	{
		tmp = head;
		head = head->pNext;
		delete tmp;
	}
}

template <class type> type List<type>::sum()
{
	Elem* temp = head;
	type sum = 0;

	while (temp != nullptr)
	{
		sum += temp->data;
		temp = temp->pNext;
	}
	return sum;
}

template <class type> int List<type>::size()
{
	int size = 0;
	Elem* temp = head;

	while(temp != nullptr)
	{
		++size;
		temp = temp->pNext;
	}
	return size;
}

template <class type> void List<type>::print()
{
	if (head == nullptr)
	{
		std::cout << "there is nothing to be shown.\n";
	}
	else
	{
		Elem* tmp = head;
		int numer = 1;

		while (tmp)
		{
			std::cout << "Element nr " << numer << " : " << tmp->data << "\n";
			numer++;
			tmp = tmp->pNext;
		}
	}
}

template <class type> List<type>::~List()
{
	Elem* tmp = head;

	while (head != nullptr)
	{
		tmp = head;
		head = head->pNext;
		delete tmp;
	}
}




int main()
{
	int ia = 15;
	int ib = 6;
	double da = 5.68;
	double db = 16.85;

	cout << min(ia, ib) << endl;
	cout << min(da, db) << endl;
	cout << max(ia, ib) << endl;
	cout << max(da, db) << endl << endl;

	cout << max(ia, da) << endl;
	cout << max(ia, db) << endl;
	cout << max(ib, da) << endl;
	cout << max(ib, db) << endl << endl;

	cout << min(ia, da) << endl;
	cout << min(ia, db) << endl;
	cout << min(ib, da) << endl;
	cout << min(ib, db) << endl << endl;

	cout << min<double>(ia, da) << endl;
	cout << min<double>(ia, db) << endl;
	cout << min<double>(ib, da) << endl;
	cout << min<double>(ib, db) << endl << endl;

	//Do not change main
	MathOperations<int> mathOperations(2, 8);
	cout << mathOperations.add() << endl;
	cout << mathOperations.subtract() << endl;
	cout << mathOperations.multiply() << endl;
	cout << mathOperations.divide() << endl << endl;

	MathOperations<double> mathOperations1(66.6, 7.34);
	cout << mathOperations1.add() << endl;
	cout << mathOperations1.subtract() << endl;
	cout << mathOperations1.multiply() << endl;
	cout << mathOperations1.divide() << endl << endl;

	//Do not change main
	List<int> list;

	list.add(12);
	list.add(15);
	list.add(18);
	list.add(21);
	list.print();

	cout << list.sum() << "\n" << list.size() << "\n";

	list.del();
	list.print();
	int i;
	cin >> i;

	return 0;
}