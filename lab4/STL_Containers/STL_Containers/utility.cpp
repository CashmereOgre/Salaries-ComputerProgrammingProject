#include "utility.h"

void disp_queue(std::queue<std::string> a_que)
{
	static int message = 1;
	std::cout << "Operation: " << message << std::endl;
	/// solution 3
	while (/**/ !a_que.empty())
	{
		std::cout << " " << a_que.front() << "  ";
		a_que.pop();
	}
	std::cout << std::endl;
	///
	message++;
}


void disp_dequeue(std::deque<std::string> a_que)
{
	static int message = 3;
	std::cout << "Operation: " << message << std::endl;
	/// solution 3
	while (/**/ !a_que.empty())
	{
		std::cout << " " << a_que.front() << ",  ";
		a_que.pop_front();
	}
	std::cout << std::endl;
	///
	message++;
}

void display_stack(std::stack<float> st)
{
	std::cout << std::endl << "Displaying stack from top:    ";
	while (!st.empty())
	{
		std::cout << st.top() << ",  ";
		st.pop();
	}
}

