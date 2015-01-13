using System;
using System.Globalization;
using System.Threading;

/*
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the of the 
floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each 
other than a fixed constant eps.
*/

class ComparingFloats
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.Write("Enter first number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter first number:");
        double secondNumber = double.Parse(Console.ReadLine());

        float eps = 0.000001f;

        bool equal = Math.Abs(firstNumber - secondNumber) < eps;

        Console.WriteLine("The numbers are equal: {0}", equal);
    }
}

