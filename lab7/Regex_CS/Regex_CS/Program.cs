using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Schema;

class RegexTask
{


    //Task1: Write boolean function IsValidPassword which checks if given in main function passowrd is valid
    //The requirements for a valid password: 
    //At least 8 characters
    //Max 15 characters 
    //At least one upper case letter 
    //At least one lower case letter
    //At lesat one digit
    //At least one special character from  (#?!@$%^&*-)
    //No white space!
    //To solve this task you can write one long pattern or a few separate

    public static bool isValidPassword(string password)
    {
        //write a pattern as a string 
        string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,15}$";

        //create a new Regex class instance 
        Regex regex = new Regex(pattern);

        // use method from the regex class which ensures if a string conforms to the patern 
        //return boolean value
        if (regex.IsMatch(password))
            return true;
        else
            return false;
    }
    //Task 2
    //Write a program which performs operations on the given in the main function strings : 'sentence' and' wordstosplit'
    //Use presented methods from the Regex class
    //Write one pattern for each task
    public static void Matches(string sentence, string wordstosplit)

    {

        //2.1 Display words in the 'sentence' separetly. Use 'Matches' method
        string pat1 = @"\b\w*\b";
        Regex reg1 = new Regex(pat1);
        MatchCollection matches1 = reg1.Matches(sentence);

        foreach (Match match in matches1)
            Console.WriteLine(match);

        //2.2 Display all Upper-case words in the 'sentence'.  Use 'Matches' method
        string pat2 = @"\b[A-Z]\w*\b";
        Regex reg2 = new Regex(pat2);
        MatchCollection matches2 = reg2.Matches(sentence);

        foreach (Match match in matches2)
            Console.WriteLine(match);

        //2.3 Display the words which start with 'th' or 'Th'in the 'sentence'. Use 'Matches' method
        string pat3 = @"(\b[th]\w*\b) | (\b[Th]\w*\b)";
        Regex reg3 = new Regex(pat3);
        MatchCollection matches3 = reg3.Matches(sentence);

        foreach (Match match in matches3)
            Console.WriteLine(match);

        //2.4 Display words which end with 'e' letter in the 'sentence'. Use 'Matches' method
        string pat4 = @"\b\w*e\b";
        Regex reg4 = new Regex(pat4);
        MatchCollection matches4 = reg4.Matches(sentence);

        foreach (Match match in matches4)
            Console.WriteLine(match);

        //2.5 Replace all 'are' with  ''re' in the 'sentence'. Use 'Replace' method
        string pat5 = @"\sare\s";
        string replace = Regex.Replace(sentence, pat5, "'re ");
        Console.WriteLine(replace);

        //2.6 Split given words seperated by '/' character in the 'wordstosplits'. Make operation only on this words which have newline character before '/' character. Use 'Split' method.
        string pat6 = @"\n/";
        string[] split = Regex.Split(wordstosplit, pat6);

        foreach (string str in split)
            Console.WriteLine(str);
    }

    // Do not modify main fucntion
    static void Main(string[] args)
    {

        Console.WriteLine("Please insert the valid password: ");
        string password;
        password = Console.ReadLine();
        if (isValidPassword(password))
            Console.WriteLine("Password is valid :)");
        else Console.WriteLine("Sorry you have put not valid password");

        string sentence = "There are Three kinds of People in this World: those who Can count and those who can Not. Change is good, but Dollars are better.";
        string wordstosplits = " \n/Ene\n/due\n/rike\n/fake---- do/not/separete/us";


        Matches(sentence, wordstosplits);
    }
}


