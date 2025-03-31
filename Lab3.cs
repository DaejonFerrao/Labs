namespace CS0603;

class Lab3
{
    public static void TestLab3()
    {
        Console.WriteLine("Testing Lab3 Tasks.......");

        // testing Even/Odd number
        Console.WriteLine("PLease enter a number to see if it is even or odd: ");
        int num = int.Parse(Console.ReadLine());
        //bool isEvenResult = IsEven(num);
        Console.WriteLine(IsEven(num) ? "Even" : "Odd");

        // testing leap year
        Console.WriteLine("PLease enter a year to see if it is a leap year: ");
        int year = int.Parse(Console.ReadLine());
        bool IsLeapYearResult = IsLeapYear(year);
        Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year");

        // testing days in a month
        DaysInMonth();
    }
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    static bool IsLeapYear(int year)
    {
        if (year % 4 != 0)
            return false;
        else if (year % 100 == 0 && year % 400 != 0)
            return false;
        else
            return true;

    }

    static void DaysInMonth()
    {
        Console.WriteLine("Please input a month:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Please input a year:");
        int year = int.Parse(Console.ReadLine());

        int days = (month == 2) ? (IsLeapYear(year) ? 29 : 28) :
                    (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;

        Console.WriteLine($"There are {days} days.");


        Console.WriteLine("End of Lab 3");

    }
}

