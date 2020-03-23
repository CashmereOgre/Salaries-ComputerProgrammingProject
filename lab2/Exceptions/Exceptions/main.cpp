/*
Exception handling -  Robert Lotawiec
*/

#include<iostream>
#include<cmath>
#include<exception>
class Logarithm
{
public:
	double base;
	double exponent;
	double *compute_logarithm(double base, double exponent);
	void calculate_and_display_score(double base, double exponent);

};
// function to evaluate logarithm a base-b
uint32_t log(uint32_t a, uint32_t b)
{
	return log2(a) / log2(b);
}
double* Logarithm::compute_logarithm(double base, double exponent)
{
	/*
	1.Logarithm exists only if three conditions are met, which are often called assumptions or logarithm domain:
	- the base of logarithms must always be a positive number, i.e. a> 0,
	-base is different from 1, therefore: a ≠ 1,
	- logarithmic number must be positive, i.e. b> 0
	2.Write the appropriate instructions to check if the given conditions are met, if not throw the appropriate type of exception (object).
	3. Consider also the logarithm case when both parameters have the same value, in this case throw the exception value 1.
	4. In addition, when one of the parameters of the logarithm will be the square of the value of the other one,
	in this case throw as an exception a variable of type char 's' denoting square.
	5.Throwing Exceptions After Destroying Objects in order to avoid memory leaks
	*/
	if (base <= 0)
	{
		throw std::out_of_range("Base isn't a positive number\n");
	}
	if (base == 1)
	{
		throw std::invalid_argument("Base can't be equal to 1\n");
	}
	if (exponent <= 0)
	{
		throw std::domain_error("Exponent isn't a positive number\n");
	}
	if (exponent == base)
	{
		throw 1;
	}
	if ((exponent * exponent) == base || (base * base) == exponent)
	{
		throw "s\n";
	}


	/*calculate the logarithm for the given parameters and return the calculation result*/
	double* res = new double;
	*res = log(base, exponent);
	return res;
}

void Logarithm::calculate_and_display_score(double base, double exponent)
{
	/*
	1.Write the body of the function that handles all possible exceptions to the compute_logarithm function.
	2.Use the try and catch keywords.
	3.Handle exceptions for type int, domain_error and for one of the logic_error - you have to precise what logic_error do you mean,
	and perform default support for the remaining options.
	*/
	try
	{
		double* calcLog = compute_logarithm(base, exponent);
		std::cout << "Logarithm with base " << base << " and exponent " << exponent << " is equal to " << *calcLog << std::endl;
	}
	catch (int i)
	{
		std::cout << "Exception int catched, result is equal to 1\n";
	}
	catch (std::domain_error)
	{
		std::cout << "Exception domain_error catched, exponent is smaller or equal to 0\n";
	}
	catch (std::logic_error LogEr)
	{
		if (LogEr.what() == "Base isn't a positive number\n")
			std::cout << "Exception out_of_range of type logic_error catched, base is smaller or equal to 0\n";
		else
			throw LogEr;
	}
	catch (...)
	{
		std::cout << "Exception default catched, one of parameter is square value of the other one\n";
	}
}

	/*
	Define a class called Exception that inherits from the std::runtime_error class,
	define constructor of class Exception that passes a string message to the runtime_error class : "Math error: Attempted to divide by Zero\n"
	*/

class Exception : public std::runtime_error
{
public:
	Exception() : runtime_error("Math error : Attempted to divide by Zero")
	{

	}
};


//  Division function 
float Division(float num, float den)
{

	// If denominator is Zero throw user defined exception of type Exception 
	if (den == 0)
		throw Exception();

	// otherwise return the result of division 
	return (num / den);
}

int main()
{
	/*
	1. Write in the main function to catch exceptions from the object of the logic_error class
	from the else statement in the function calculate_and_display_score.
	2. Create the object of the Exception class and and handle possible exeptions
	*/


	float numerator, denominator, result;
	numerator = 8;
	denominator = 0;

	// write try block calls the Division function 

	try
	{
		result = Division(numerator, denominator);
		std::cout << "Result: " << result << std::endl;
	}

	// write catch block for the Division function that catches exception if any of type Exception occurs
	catch (Exception except)
	{
		// prints that exception has occurred; calls the what method using object of the user defined class called Exception 
		std::cout << "Exception of type " << except.what() << " occured.\n";
	}


	/* write try and catch block for the Logarithm function	(create an object and call void calculate_and_display_score(double base, double exponent) )
	that catches any exception - take into account all posibilities (deafult case also), use what() when neccessary
	*/

	try
	{
		Logarithm log;
		log.base = 1;
		log.exponent = 2;
		log.calculate_and_display_score(1, 1);
		log.calculate_and_display_score(-2, 4);
		log.calculate_and_display_score(3, 3);
	}
	catch (std::logic_error LogEr)
	{
		std::cout << LogEr.what() << std::endl;
	}
	catch (std::out_of_range OoR)
	{
		std::cout << OoR.what() << std::endl;
	}
	catch (...)
	{
		std::cout << "Default exception";
	}
	return 0;
}