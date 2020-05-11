
#include "Test.hpp"
#include <iostream>
#include <sstream>
#include <regex>        // Regex lib





/*
    Task #1:

    Trolls are attacking your comment section!
    A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.

    Your task is to write a function that takes a string and return a new string with all vowels removed.
    For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".
*/
std::string Task1_Solution(std::string const& post)
{
    // 1. Declare regex that describes the class, which contains all vowels
    std::regex vowels("[aAeEIiOoUuYy]");

    // 2. Return post with all vowels raplaced by ""
    std::string replace = std::regex_replace(post, vowels, "");
    return replace;
}




/*
    Task #2:

    A dangerous bacteria named 'Examus Unpassinus' escaped military's base laboratory!
    The government has put you in charge to deal with the threat. Thausends of student's lifes are in danger!

    Your task is to implement the function that recognizes bacteria's genes.
    The research has discovered that this specific bacteria can be ditinguished by following traits:

        Trait 1:    Pure Examus Unpassinus has a characteristic sequence of genes. "2" is repeated 5 or more times, but mutations may not posses this trait
        Trait 2:    If bacteria's DNA code contains the sequence "AECOPG", then if double occurance of "UE" is followed by more than one "OIU" the bacteria may be Examus Unpassinus
        Trait 3:    Examus Unpassinus bacteria's genes never contain the squence "NOT", followed by "ME"
*/
bool Task2_Solution(std::string const& DNA)
{
    // 1. Declare regex named 'bacteria_trait1' that describes the bacteria 1st trait
    std::regex bacteria_trait1("2{5,}");

    // 2. Declare regex named 'bacteria_trait2' that describes the bacteria 2nd trait
    std::regex bacteria_trait2("AECOPG(.*UE.*){2}(.*OIU){2,}");

    // 3. Declare regex named 'bacteria_trait3' that describes the bacteria 3rd trait
    std::regex bacteria_trait3("((?!NOT.*ME).)*");



    // Checks and returns if std::regex_match has found the bacteria
    return (std::regex_match(DNA, bacteria_trait3) and (std::regex_match(DNA, bacteria_trait1) or std::regex_match(DNA, bacteria_trait2)));
}






/*
    Task #3:

    In 'extra' folder, there is file called 'People.csv'.
    The data is formatted as such:

        Name Surname;Phone;Email;City;Newsletter

        Phone has format '+48 XXX-XXX-XXX'
        Email has format 'abc@abc.abc'
        Newsletter is boolean value represented by Y/N


    Read this file, and search following cases:

        +   Find all people that live in Pica, Bacabal or Coleville Lake
        +   Then, narrow search result down to the people, that provided email in domain .ca and subscribes newsletter
*/
void Task3_Solution()
{
    ___START_TASK("3")

    std::stringstream ssData = ReadWholeFile("People.csv");     // Stream contains data from People.csv file
    std::string line;     // Buffer


    // 1. Declare regex that matches whole line from ssData
    // 2. Modify group that corresponds to the City to match exact locations
    // 3. Do the same with groups that correspond to Email and Newsletter
    std::regex regex("(.*);(.*);(.*@.*.ca);(Pica|Bacabal|Coleville Lake);(Y)");

    // 4. Read the stream line by line
    // 5. Test if the line matches format 
    // 6. If it does display whole line and separate fields
    while (std::getline(ssData, line))
    {
        std::smatch data;

        if (std::regex_match(line, data, regex))
        {
            std::cout << "Whole user data: " << line << std::endl;
            std::cout << "Name and Surname: " << data[1] << std::endl;
            std::cout << "Phone number: " << data[2] << std::endl;
            std::cout << "E-mail: " << data[3] << std::endl;
            std::cout << "City: " << data[4] << std::endl;
            std::cout << "Newsletter: " << data[5] << std::endl;
        }
    }




    ___END_TASK
}




/*
    Task 4:

    In 'extra' folder you'll find a file called 'Encrypted-Msg.txt' and 'Code.txt'

        +   Decrypt the message from 'Encrypted-Msg.txt', using code defined in file 'Code.txt'
        +   What does the encrypted message says?
*/
void Task4_Solution()
{
    ___START_TASK("4")


        std::stringstream ssCode = ReadWholeFile("Code.txt");
    std::string message = ReadWholeFile("Encrypted-Msg.txt").str(), line;


    // Displays encrypted message
    std::cout << "Encrypted message: '" << message << "'\n\n";


    // 1. Declare regex that will extract sequence to replace and its meaning from each line
    // Hint:    Both sequences are between '"'. 
    //          A sequence to replace is always followed by its meaning, but both can be surraunded by dummy text.
    std::regex whole_line(".*\"(.*)\".*\"(.*)\".*");
    // 2. Read data line by line
    // 3. Check if line matches format
    // 4. If it does:
    //      - Display character sequence along with its transation
    //      - Replace the sequence in message with its translation 
    while (std::getline(ssCode, line))
    {
        std::smatch matching_line;

        if (std::regex_match(line, matching_line, whole_line))
        {
            std::cout << matching_line[1] << " is translated to " << matching_line[2] << std::endl;
            message = std::regex_replace(message, std::regex(matching_line[1].str()), matching_line[2].str());
        }
    }


    // Displays decrypted message
    std::cout << "True meaning revealed! Get ready to know the biggest secret of humanity!\n" << message << std::endl;

    ___END_TASK
}



int main() try  // Don't modify main
{
    Check_Task1(Task1_Solution);
    Check_Task2(Task2_Solution);

    Task3_Solution();
    Task4_Solution();

    return 0;
}
catch (...)
{
    std::cout << "Painful error: Something went wrong... But I don't know what.\n";
}
