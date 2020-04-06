#pragma once
#include<deque>
#include<queue>
#include<list>
#include<stack>
#include<set>
#include<iostream>
#include<string>
#include<map>
#include<utility>

void disp_queue(std::queue<std::string> a_que);


void disp_dequeue(std::deque<std::string> a_que);

template<typename T>
void display_list(std::list<T>lst)
{

	int lst_size = lst.size();
	for (int i = 0; i < lst_size; i++)
	{
		std::cout << lst.front() << "; ";
		lst.pop_front();
	}
}

void display_stack(std::stack<float> st);
