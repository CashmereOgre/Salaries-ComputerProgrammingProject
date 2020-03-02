/*
 *	Copyright Bart³omiej Piura & Pawe³ Szafraniec 2020
 */
#include <string>
#include <vector>
#include <iostream>
#include <typeinfo>

 /*
	 Make something that such that class will be polymorphic.
 */
class Component 
{
public:
	virtual void write_message(const std::string& message)
	{
		std::cout << "Well..." << std::endl;
	}
};

/*
	Make something that such that class will be polymorphic.
*/
class Describable 
{
public:
	virtual void function()
	{
		std::cout << "Undescribable..." << std::endl;
	}
};

class Writer : public Component, public Describable
{
public:

	/*
	Should write given message to console. Name of this class should also be written, but it can't be hardcoded (use RTTI).
	*/
	virtual void write_message(const std::string& message)
	{
		std::cout << message << std::endl;
		std::cout << typeid(*this).name() << std::endl;
	}
};

class WriterWithHistory : public Writer, public Describable
{
public:
	std::vector<std::string> history;
	/*
		Call 'write_message' from Writer class, and store given message. (Some extra fields should be added)
	*/
	void write_message(const std::string& message)
	{
		Writer::write_message(message);
		history.push_back(message);
	}

	/*
		Return all stored messages.
	*/
	const std::vector<std::string>& get_messages()
	{
		return history;
	}
};

/*
	Print history of the given writer. If it hasn't history, inform user about it.
*/
void printHistory(Writer* w)
{
	WriterWithHistory* wptr = dynamic_cast<WriterWithHistory*>(w);

	if (wptr)
	{
		std::vector<std::string> his = wptr->get_messages();
		for (int i = 0; i < his.size(); i++)
		{
			std::cout << his[i] << std::endl;
		}
	}
	else
	{
		std::cout << "This writer doesn't has history, because he is so bad at wrining, that no one reads that." << std::endl;
	}
}


class Logger 
{
public:
	/*
		Store somewhere name of the type of the given component.
	*/
	std::string LogName;
	Logger(Component* o)
	{
		LogName = typeid(*o).name();
	}

	/*
		Print given message and stored type name.
	*/
	void print(std::string m)
	{
		std::cout << m << ", " << LogName << std::endl;
	}
};

/*
	1. Create object of Component, Writer and WriterWithHistory.
	2. Call write_message on Writer and WriterWithHistory few times with different messages.
	3. Pass both writers to printHistory function. What happened?
	4. Create logger for each of created objects.
	5. Call print function for each created logger.
	6. Using dynamic_cast cast a pointer of WriterWithHistory to Component pointer
		and Describable pointer. Write to the console values of both pointers. What is the result? Why?
*/
int main()
{
	int p;
	Component comp;
	Writer S³owacki;
	WriterWithHistory Mickiewicz;
	S³owacki.write_message("Virgin");
	S³owacki.write_message("Slowacki");
	Mickiewicz.write_message("Chad");
	Mickiewicz.write_message("Mickiewicz");
	printHistory(&S³owacki);
	printHistory(&Mickiewicz);
	Logger log1(&S³owacki);
	Logger log2(&Mickiewicz);
	Logger log3(&comp);
	log1.print("Slo");
	log2.print("Mic");
	log3.print("co");
	Component* compMic = dynamic_cast<Component*>(&Mickiewicz);
	Describable* descMic = dynamic_cast<Describable*>(&Mickiewicz);
	std::cout << compMic << ", " << descMic << std::endl;
	std::cin >> p;
	return 0;
}
