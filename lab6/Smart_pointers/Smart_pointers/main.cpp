#include <iostream>
#include <memory>
#include <string>
#include <vector>

using namespace std;

class Cake
{
public:
	Cake() : type("Ciasto") {}
	Cake(string t) : type(t) {}

	void displayType()
	{
		cout << "Type of the cake: " << type << endl;
	}

private:
	string type;
};

struct Cookie {
	Cookie(string n) : name(n) {}
	void displayName()
	{
		cout << "Name of the cookie: " << name << endl;
	}
	string name;
};

vector<shared_ptr<Cake>> cakes;

void uniquePointer()
{
	//Create unique pointer to Cake class use make_unique and name the cake however you like
	std::unique_ptr<Cake> a = std::make_unique<Cake>("Brownie");
	//Display type of the cake
	a->displayType();
	//Create second unique pointer to class Cake, transfer control from the first pointer
	std::unique_ptr<Cake> b = std::move(a);
	//Display type of the cake using second pointer
	b->displayType();
	//What if you would try to display Cake type from first pointer? Check. Why?
	//a->displayType();
	//access violation
}

//Design a function printing number of references of given pointer
//Function should take any shared pointer
//Ensure, that this function will not interfere in reference count
template<class type>
void displayReferencesCount(std::shared_ptr<type> ptr)
{
	//Print number of references from passed pointer
	std::cout << ptr.use_count() << std::endl;
}

template<class type>
void displayReferencesCountWeak(std::weak_ptr<type> ptr)
{
	//Print number of references from passed pointer
	std::cout << ptr.use_count() << std::endl;
}
//Function should take shared pointer without interfering into reference count
void sharedPointer(std::shared_ptr<Cake> ptr)
{
	cout << endl;
	//Display reference count to check if everything works fine
	displayReferencesCount(ptr);
	{
		//Copy passed pointer to the new one
		shared_ptr<Cake> newone = ptr;
		//Display references count of the original pointer
		displayReferencesCount(ptr);
		//Insert copy into cakes vector
		cakes.push_back(newone);
		//What is the count of the references now?
		displayReferencesCount(ptr);
		//Display type of cake
		newone->displayType();
	}
	//What is the difference in count? Check
	displayReferencesCount(ptr);
	cout << endl;
}

//Pass shared pointer of type Cake
void resetPointer(std::shared_ptr<Cake> ptr)
{
	cout << endl;
	//Display reference count of pointer
	displayReferencesCount(ptr);
	//Reset pased pointer so it holds another one, Cake should have different name
	ptr.reset(new Cake("Pavlova"));
	//Display cake type
	ptr->displayType();
	//Display reference count of pointer
	displayReferencesCount(ptr);
	cout << endl;
}

void getRaw()
{
	//Create shared pointer to Cookie class with whatever name
	std::shared_ptr<Cookie> a = make_shared<Cookie>("Oreo");
	//Create raw pointer to the same member as shared pointer
	Cookie* raw = a.get();
	//Display cookie's name from shared and raw pointers
	raw->displayName();
	a->displayName();
	//Check reference count of shared pointer, is it incremented or not, why?
	displayReferencesCount(a);
	//What would happen, when the raw pointer gets deleted? Check. Why?
	//delete raw;
	//can't load symbols
}

void weakPointer()
{
	cout << endl;
	//Create a shared pointer
	std::shared_ptr<Cake> a = make_shared<Cake>("Schwarzwald");
	//Print its use count 
	std::cout << a.use_count() << std::endl;
	//Create a weak pointer that observes it
	std::weak_ptr<Cake> weak = a;
	//Display reference count. What are the values?
	displayReferencesCount(a);
	//Assign a weak pointer to a shared pointer
	a = weak.lock();
	//Check that the weak pointer is not empty
	if (!weak.expired())
		std::cout << "Not empty\n";
	//Assign a weak pointer to another weak pointer
	std::weak_ptr<Cake> weaka = weak;
	//Display reference count of a weak pointer
	displayReferencesCountWeak(weak);
	//Assign a weak pointer to another shared pointer
	std::shared_ptr<Cake> b = weaka.lock();
	//Display reference count of a weak pointer
	displayReferencesCountWeak(weaka);
	cout << endl;
}

//Create a doubly linked list using shared pointers
//It will be used in the next function
//Ensure proper memory management!
class List {
public:
	//next element
	std::shared_ptr<List> next;
	//previous element
	std::shared_ptr<List> prev;
};
void listLink()
{
	//Create shared pointer to the previously created class, construct using make_shared
	std::shared_ptr<List> head = make_shared<List>();
	//Create a shared pointer to this class for next element of List, use new keyword
	head->next = std::shared_ptr<List>(new List());
	//Set pointer to previous element in the next element as the originaly created pointer //head->next->prev = head
	head->next->prev = head;
	//Are there any memory leaks?
	//If so why? Change List class to eliminate possible problems
}

//Create custom deleter for Cookie class
template <class t>
class Deleter
{
public:
	void operator()(t* p) const
	{
		std::cout << "Cookie deleted\n";
		delete p;
	}
};

//Check your deleter
void customDeleterCheck()
{
	//Create unique_ptr to class Cookie with custom deleter of class Deleter
	std::unique_ptr<Cookie, Deleter<Cookie>> cookie(new Cookie("Hedgehogs"), Deleter<Cookie>());
}


//Check for additional instructions
int main()
{
	uniquePointer();
	//Create shared pointer of type Cake("name_of_your_cake") 
	std::shared_ptr<Cake> cake = make_shared<Cake>("Sacher");
	//Pass it to the function below
	sharedPointer(cake);
	//Pass it to the function below
	resetPointer(cake);
	cout << endl;
	//Display type of cake from vector cakes
	cakes.at(0)->displayType();
	//Display its reference count
	displayReferencesCount(cakes.at(0));
	cout << endl;
	getRaw();
	weakPointer();
	listLink();
	customDeleterCheck();

	return 0;
}