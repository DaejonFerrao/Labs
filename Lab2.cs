using System.IO.Compression;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;

namespace CS0603;

class Lab2

{
    // this is the entry point of Lab2 taks, the following function
    // should be called in the Main function in Program.cs
    public static void TestLab2()
    {
        Console.WriteLine("Task 2.3: Variables and Expressions\n");

        //Values of the variables
        int a = 5;
        double b = 2.3;
        double c = 1.2;
        string f = " a student";
        long x = 0;
        double y = 0.0;
        string z = "";
        double pi = 3.142; 

        // Task 1, x = a +b
        x = (long) (a + b);
        Console.WriteLine($"x = a + b, the value of x is: {x}");

        //Task 2, y = a + b
        y = (double) (a + b);
        Console.WriteLine($"y = a + b, the value of y is: {y}");

        //Task 3, y = b * c
        y = (double) (b * c);
        Console.WriteLine($"y = b * c, the value of y is: {y}");

        //Task 4. z = name
        z = (string) (f);
        Console.WriteLine($"name is: {z}");

        //Task 5, y = ax^2+bx+c
        x = -2;
        y = (long) (a * x * 2 + b * x + c);
        Console.WriteLine($"The value of y is: {y}");

        //Task 6, y = y/3
        y = 100.9;
        y = (long) y / 3;
        Console.WriteLine($"The value of y: {y}");

        //Task 7, pi
        y = (long) ((pi + 1/pi + 2)/pi + 3);
        Console.WriteLine($"The value of y is: {y}"); 

        Console.WriteLine($"The end of Task 2");
    }
}