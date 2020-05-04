#include <iostream>
#include <thread>
#include <mutex>
#include <chrono>

std::mutex m;

//Create 3 functions that each will generate different character 10 times
//Each function should have argument int i
void generate_a(int i)
{
	for (i; i < 10; i++)
		std::cout << "a";
}
void generate_b(int i)
{
	for (i; i < 10; i++)
		std::cout << "b";
}
void generate_c(int i)
{
	for (i; i < 10; i++)
		std::cout << "c";
}

//Write body of function pause that would pause the active thread and will write for how long it was paused
void pause(int n)
{
	std::this_thread::sleep_for(std::chrono::seconds(n));
	std::cout << "Ongoing thread will now pause for " << n << " seconds.\n";
}

//Write here a function printing 3 times an id of a thread using std::lock_guard too
void thread_id()
{
	std::lock_guard<std::mutex> lg(m);
	for (int i = 0; i < 3; i++)
		std::cout << "Thread id: " << std::this_thread::get_id() << std::endl;
}


int main()
{
	unsigned int n;
	//Call here a function returning number of threads supprted by CPU
	n = std::thread::hardware_concurrency();
	std::cout << "Number of threads supported by CPU is: " << n << std::endl;

	//Call here all character generators and observe what happens when you put join() 
	//for each thread after calling all generators
	int i = 0;
	std::thread gen_a(generate_a, std::ref(i));
	std::thread gen_b(generate_b, std::ref(i));
	std::thread gen_c(generate_c, std::ref(i));
	gen_a.join();
	gen_b.join();
	gen_c.join();

	//Here observe the difference when you put join() after calling each generator for each thread
	//Can you call again the same threads or do you need to create new ones?
	
	//I need to create new generators
	std::thread generator_a(generate_a, std::ref(i));
	generator_a.join();
	std::thread generator_b(generate_b, std::ref(i));
	generator_b.join();
	std::thread generator_c(generate_c, std::ref(i));
	generator_c.join();
	//Create here a character generating thread using lambda

	std::thread generator_d([&i]
	{
		for (i; i < 10; i++)
			std::cout << "d";
	}
	);

	generator_d.join();

	//In this part call 3 different threads for function pause() with different timings
	//Here please skip naming threads and immediately detach them.

	std::thread(pause, 2).detach();
	std::thread(pause, 5).detach();
	std::thread(pause, 10).detach();

	std::cout << "Here, let's give detached threads a little time to finish" << std::endl;
	pause(10);

	//In this threads call function printing id of a thread
	//Does it print it correctly?
	std::thread t1([]
	{
		thread_id();
	});

	std::thread t2([]
	{
		thread_id();
	});
	t1.join();
	t2.join();

	return 0;
}