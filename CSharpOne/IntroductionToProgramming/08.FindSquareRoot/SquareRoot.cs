using System;

/*
Create a console application that calculates and prints the square root of the number 12345.
Find in Internet “how to calculate square root in C#”.
*/

class SquareRoot
{
    static void Main()
    {
        double number = 12345;
        double numberSqrt = Math.Sqrt(number);

        Console.WriteLine("The square root of {0} is: {1}", number, numberSqrt);
    }
}
