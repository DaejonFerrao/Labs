using System;

namespace CS0603;

class Lab4
{
    public static void DisplaySequenceFunctions()
    {
        Console.WriteLine("Sequence Functions:");

        Console.Write("Sequence 1: ");
        for (int i = 0; i < 4; i++)
        {
            int number = 10 + (i * 3);
            Console.Write(number + ", ");
        }
        Console.WriteLine();

        Console.Write("Sequence 2: ");
        for (int i = 1; i <= 10; i++)
        {
            int number2 = i * i;
            Console.Write(number2 + ", ");
        }
        Console.WriteLine();

        Console.Write("Sequence 3: ");
        for (int i = 0; i <= 10; i++)
        {
            int number3 = -10 + (i * 2);
            Console.Write(number3 + ", ");
        }
        Console.WriteLine("\n");
    }

    public static void DataCalculation()
    {
        Console.WriteLine("Data Calculation:");

        Console.Write("Numbers divisible by 2 and 3: ");
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0 && i % 3 == 0)
            {
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine();

        Console.Write("Numbers divisible by 2 and 3, but not 5: ");
        for (int i = 1; i < 100; i++)
        {
            if (i % 2 == 0 && i % 3 == 0 && i % 5 != 0)
            {
                Console.Write(i + ", ");
            }
        }
        Console.WriteLine("\n");
    }

    public static int Factorial(int x)
    {
        if (x < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
            return -1;
        }

        if (x == 0)
        {
            return 1;
        }

        int result = 1;
        for (int i = x; i >= 1; i--)
        {
            result *= i;
        }

        return result;
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Menu");
        Console.WriteLine("1. Sequence Functions");
        Console.WriteLine("2. Data Calculation");
        Console.WriteLine("3. Factorial Calculation");
        Console.WriteLine("4. Exit");
    }

    static void PressAnyKeyToContinue()
    {
        Console.WriteLine("Press any key to return to the main menu");
        Console.ReadKey();
    }

    public static void Lab4Function()
    {
        bool continueLoop = true;

        while (continueLoop)
        {
            DisplayMenu();

            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Sequence Functions:");
                    DisplaySequenceFunctions();
                    PressAnyKeyToContinue();
                    break;
                case "2":
                    Console.WriteLine("Data Calculation:");
                    DataCalculation();
                    PressAnyKeyToContinue();
                    break;
                case "3":
                    Console.Write("Enter a positive number to calculate its factorial: ");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        int factorialResult = Factorial(num);
                        if (factorialResult != -1)
                        {
                            Console.WriteLine($"Factorial of {num} is: {factorialResult}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for factorial. Please enter a positive number.");
                    }
                    PressAnyKeyToContinue();
                    break;
                case "4":
                    Console.WriteLine("The application ends here.");
                    continueLoop = false;
                    break;
                default:
                    Console.WriteLine("Incorrect input, please select again.");
                    break;
            }
        }
    }
}