

#include "Test.hpp"


#include <iostream>
#include <map>
#include <regex>
#include <fstream>
#include <sstream>



#define HR( __LENGTH )\
    std::cout << std::setfill('-') << std::setw(__LENGTH) << '\n' << std::setfill(' ');




#define THEAD_LABEL( __label, __size)\
    std::cout << '|' << std::setw(__size) << __label;\

#define THEAD \
    int i = 0;\
    HR(122)\
    THEAD_LABEL("Test No. ", 15)\
    THEAD_LABEL("Input ", 35)\
    THEAD_LABEL("Function result ", 25)\
    THEAD_LABEL("Expected result ", 25)\
    THEAD_LABEL("Status ", 15)\
    std::cout << "|\n";\
    HR(122)



#define TD( input, res1, res2)\
    std::cout << '|' << std::setw(15) << i++;\
    std::cout << '|' << std::setw(35) << input;\
    std::cout << '|' << std::setw(25) << res1;\
    std::cout << '|' << std::setw(25) << res2;\
    std::cout << '|' << std::setw(15) << ((res1 == res2) ? "Passed" : "Wrong result") << "|\n";



#define MAKE_TEST(__function_name, __type1, __type2, ...)\
    THEAD\
    for(auto unit: std::map<__type1, __type2> { __VA_ARGS__ } )\
    {\
        auto result = __function_name(unit.first);\
        TD(unit.first, result, unit.second)\
    }\
    HR(122)







void Check_Task1(std::string solution(std::string const&))
{
    std::cout << "\nChecking Task 1 ...\n";

    MAKE_TEST(
        solution,
        std::string, std::string,
        { "This website is for losers LOL!", "Ths wbst s fr lsrs LL!" },
        { "WOW! That was stupid", "WW! Tht ws stpd" },
        { "empty->aeiouAEIOU<-empty", "mpt-><-mpt" }
    );
}


void Check_Task2(bool solution(std::string const&)) try
{
    std::cout << "\nChecking Task 2 ...\n";

    MAKE_TEST(
        solution,
        std::string, bool,
        { "NOTME", false },
        { "NOT ME", false },
        { "AGAINNOTME", false },
        { "AECOPG UEUE OIUOIU", true },
        { "NOTME BUT AECOPG UEUE OIUOIU", false },
        { "AECOPG dasda UEUE gfr OIU", false },
        { "AECOPGUE", false },
        { "NOT ME 222222", false },
        { "222222", true },
        { "22222", true },
        { "2222", false }
    );
}
catch (std::regex_error& e)
{
    std::cout << "Woah, the regex caused exception\n";
    std::cout << e.what() << '\n';
}



std::stringstream ReadWholeFile(std::string const& filename)
{
    std::ifstream fIn(filename, std::ios::in | std::ios::binary);   // Input file stream
    std::stringstream contents;                                     // Contents of the file (Return value)

    if (fIn)                         // If file exists
    {
        contents << fIn.rdbuf();    // Read whole file
        fIn.close();                // Close it
    }

    return contents;                // Return contents of the file
}








#undef HR
#undef THEAD
#undef TD
#undef TEST_UNIT
