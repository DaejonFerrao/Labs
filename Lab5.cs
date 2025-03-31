using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace CS0603;

class Lab5
{
    public static void TestLab5()
    {
        {
            int[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int result = 0;
            for (int i = 0; i < X.Length; i++)
            {
                result += X[i] * X[i];
            }


            Console.WriteLine("The result is: " + result);
        }

        static void CountingDigits()

        {
            string inputString;
            double number;

            while (true)
            {
                Console.Write("Please enter a decimal number: ");
                inputString = Console.ReadLine();

                if (double.TryParse(inputString, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid number, please try again"); //error message
                }

                int digitsBeforeDecimal = 0;
                int digitsAfterDecimal = 0;

                int decimalIndex = inputString.IndexOf(",");

                if (decimalIndex == -1)
                {
                    digitsBeforeDecimal = inputString.Length;
                    digitsAfterDecimal = 0;
                }
                else
                {
                    digitsBeforeDecimal = decimalIndex;
                    digitsAfterDecimal = inputString.Length - decimalIndex - 1;
                }

                Console.WriteLine("The number has " + digitsBeforeDecimal +
                    "digits before the decimal point, and" + digitsAfterDecimal +
                    " digits after the decimal point.");
            }
        }
    }
    static void Palindromic()
    {
        while (true)
        {
            Console.Write("Please enter an integer number: ");
            string inputString = Console.ReadLine();

            if (int.TryParse(inputString, out int number))
            {
                string reversedString = "";
                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    reversedString += inputString[i];
                }

                if (inputString == reversedString)
                {
                    Console.WriteLine("The input is a palindromic number.");
                }
                else
                {
                    Console.WriteLine("The input is NOT a palindromic number.");
                }

                Console.Write("Do you want test another number, yes/no");
                string continueChoice = Console.ReadLine().ToLower();

                if (continueChoice == "no")
                {
                    Console.WriteLine("Test for palindromic number is terminated");
                    break;
                }
                else if (continueChoice != "yes")
                {
                    Console.WriteLine("Invalid Input, test terminated");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Input is not an integer number, please try again");
            }
        }
    }

    static void Task_5_4()
    {
        int[,] numbers = new int[4, 4];
    Random random = new Random();

        for (int i = 0; i<numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write(numbers[i, j] + "\t");
            }
            Console.WriteLine();
        }

        twoDArray(numbers, true);

        twoDArray(numbers, false);
    }

    static void twoDArray(int[,] inputArray, bool isRow)
    {
        if (isRow)
        {
            Console.WriteLine("\nRow Sums: ");
            for (int i = 0; i < inputArray.GetLength(0); i++)
            {
                int rowSum = 0;
                for (int j = 0; j < inputArray.GetLength(1); j++)
                {
                    rowSum += inputArray[i ,j];
                }
                Console.WriteLine("Row " + i + "'s sum: " + rowSum);
            }
        }
        else
        {
            Console.WriteLine("\nColumn Sums: ");
            for (int j = 0; j < inputArray.GetLength(1); j++)
            {
                int colSum = 0;
                for (int i = 0; i < inputArray.GetLength(0); i++)
                {
                    colSum += inputArray[i, j];
                }
                Console.WriteLine("Column " + j + "'s sum: " + colSum);
            }
        }
    }
}

