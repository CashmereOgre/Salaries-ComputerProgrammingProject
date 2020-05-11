

#ifndef TEST_HPP_INCLUDED
#define TEST_HPP_INCLUDED


#include <string>
#include <iomanip>



#define ___START_TASK( __N )\
    std::cout << '\n' << std::setfill('-') << std::setw(54) << " " << "Exercise #" << __N << " " << std::setfill('-') << std::setw(54) << '\n' << std::setfill(' ');

#define ___END_TASK\
    std::cout << "\n";


void Check_Task1(std::string solution(std::string const&));

void Check_Task2(bool solution(std::string const&));


std::stringstream ReadWholeFile(std::string const& filename);





#endif