using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;

namespace CS0603;

class Lab1
{
    public static void TestLab1()
    {
        //Console.Clear();
        Console.WriteLine("Test Lab 1 tasks......... \n");

        //Age
        int myAge = 18;
        Console.WriteLine($"My age is: {myAge}");

        //Module Name
        string moduleName = "CS0002";
        Console.WriteLine($"The name of the module is: {moduleName}");

        //Interest Rate 
        double interestRate = 0.052;
        Console.WriteLine($"The interest rate is: {interestRate}");

        //Deposit
        double initialDeposit = 100.50;
        Console.WriteLine($"This is the inital deposit: {initialDeposit}");

        //University Name
        string universityName = "Brunel University London";
        Console.WriteLine($"This is the name of the University: {universityName}");

        //Number 
        int wholeNumber = 100;
        Console.WriteLine($"this is a whole number: {wholeNumber}");

        //Full Sentence
        Console.WriteLine($"I am studying the {moduleName} module at {universityName}");

        //Final Sum
        double finalSum =  initialDeposit * (1 + interestRate);
        Console.WriteLine($"This is the final sum: {finalSum}");
    }   



} // end of the Week 1 lab tasks, dont enter any codes below