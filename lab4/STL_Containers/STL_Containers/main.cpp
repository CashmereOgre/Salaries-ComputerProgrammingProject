#include<vector>
#include<iomanip>
#include"utility.h"


//1. Create a function displaying matrixes stored as vector of int vectors 
	//eg.
		//   |  0   1   2|
		//   |  3   4   5|
		//   | -6  -7   8|
	//display all the elements as there was presentet above (TIP: assume std::setw(3))
	//you can assume square matrix 
void disp_matrix(std::vector < std::vector<int>>& vec)
{
	///solution 1
	for (int i = 0; i < vec.size(); i++)
	{
		std::cout << "|";
		for (int j = 0; j < vec[i].size(); j++)
		{
			std::cout << std::setw(3) << vec[i][j];
		}
		std::cout << "|" << std::endl;
	}

	///
}

//Problem 2.  Create a function RESIZING the the vector of vectors square matrix n x m to square matrix (n-1)x(m-x)
//Problem 3.  Convert it as a list of size n x m (it is not necessary to create list of list just create one longer) return that list
std::list<int> shrink_square_matrix(std::vector <std::vector<int>>&vec)
{
	///solution 2
	std::list<int> matrix_in_list;
	int li = vec.size() - 1;
	int lj = vec[0].size() - 1;

	vec.resize(li);

	for (int i = 0; i < li; i++)
	{
		vec[i].resize(lj);
		for (int j = 0; j < lj; j++)
		{
			matrix_in_list.push_back(vec[i][j]);
		}
	}
	return matrix_in_list;
	///
}
//Problem 4. The argument of function is list of many lenghts in cm. Replace them with their corresponding lenght in inchs (inch=2.54cm)
//return sum of lenghts in inches
//do not use iterator just push back to the empty list
double sum_of_inches(std::list<double>&lenght_list)
{
	std::list<double> empty;
	double sum = 0;
	///solution 4
	for (int i = 0; i < lenght_list.size(); i++)
	{
		empty.push_back(lenght_list.front() * 2.54);
		sum += lenght_list.front() * 2.54;
		lenght_list.pop_front();
	}
	///
	lenght_list = empty;
	return sum;
}

//problem 5. in dque_do_smthg
//a)	create 2 QUEUES in one put 5 in second 2 full names of your choice. After all of that them use funtion disp_queue from utility.cpp on both of queues
//b)	merge them into dequem ,the order does not matter, assign it to argument. Make sure that there is no previus data in deque

void dque_do_smthg(std::deque<std::string>&dqueue)
{
	///solution 3
	std::queue<std::string> five;
	std::queue<std::string> two;

	five.push("John Joemoon");
	five.push("Jomato Matojo");
	five.push("Jean Pierre Piernareff");
	five.push("Mohamed Actul");
	five.push("Noriaki Kakyosai");

	two.push("Giordano Giotto");
	two.push("Bruno Bucaretti");
	
	disp_queue(five);
	disp_queue(two);

	dqueue.clear();

	while (!five.empty())
	{
		dqueue.push_back(five.front());
		five.pop();
	}
	while (!two.empty())
	{
		dqueue.push_back(two.front());
		two.pop();
	}
}
//Problem 6 remove the second object on stack from top (remeber that top variable should not disappear)
void stack_remove_sec_from_top(std::stack<float> &st)
{
	///sol 6
	float temp = st.top();
	st.pop();
	st.pop();
	st.push(temp);
}
//Problem 7 Display all elements form 0 to N contained in set.
void show_set_elem(std::set<unsigned int> ui_set, int N)
{
	///7
	for (int i = 0; i < N; i++)
	{
		if (ui_set.count(i))
		{
			std::cout << i << " ";
		}
	}
}
//Problem 8 Display all coords basing on x-axis
void show_map_elem(std::map<int, int> coord_map, int x_min, int x_max)// get val pair.first or pair.second
{
	///8
	for (int i = x_min; i < x_max; i++)
	{
		if (coord_map.count(i))
			std::cout << "x = " << i << ", y = " << coord_map[i] << std::endl;
	}
}

int main()
{

	std::cout << "Problem 1:" << std::endl;
	std::vector<std::vector<int>> vec = { {0,1,2},  {3,4,5},  {-6,-7,-8} };
	disp_matrix(vec);

	std::cout << std::endl << "Problem 2 :" << std::endl;
	std::cout << std::endl << "Resizing..." << std::endl << std::endl;
	std::list<int> lst = shrink_square_matrix(vec);
	disp_matrix(vec);
	std::cout << std::endl << std::endl << "Problem 3" << std::endl << std::endl << "The matrix converted to list: ";
	display_list(lst);

	std::cout << std::endl << std::endl;
	std::cout << "Problem 4:" << std::endl << std::endl;
	std::list<double> lngth;
	lngth.push_back(2.489626556016);
	lngth.push_back(100);
	lngth.push_back(4.14937759336099);
	lngth.push_back(200);
	std::cout << "A list before any operations: " << std::endl;
	display_list(lngth);
	std::cout << std::endl << std::endl << "The sum is a:" << sum_of_inches(lngth) << std::endl << "A list after many operations:" << std::endl;
	display_list(lngth);
	std::cout << std::endl << std::endl << "Problem 5" << std::endl << std::endl;
	std::deque<std::string> a;
	a.push_back("this should not be");
	a.push_back("displayed");
	dque_do_smthg(a);
	std::cout << std::endl;
	disp_dequeue(a);
	std::cout << std::endl << "Problem 6" << std::endl;
	std::stack<float> fstack;
	fstack.push(0.402005);
	fstack.push(10.2);
	fstack.push(111.32);//remove this
	fstack.push(1.37);

	display_stack(fstack);
	stack_remove_sec_from_top(fstack);
	display_stack(fstack);

	std::cout << std::endl << std::endl << "Problem 7" << std::endl << std::endl;
	std::set<unsigned int> ui;
	ui.insert(13);
	ui.insert(32);
	ui.insert(2933);
	ui.insert(3);
	ui.insert(1999);
	ui.insert(34);
	ui.insert(99);
	show_set_elem(ui, 3000);

	std::cout << std::endl << std::endl << "Problem 8" << std::endl << std::endl;
	std::map<int, int> crds;
	crds[-10] = 31;
	crds[0] = 13;
	crds[5] = 99;
	crds[-3] = -5;
	crds[1] = 2;
	show_map_elem(crds, -20, 20);
}
