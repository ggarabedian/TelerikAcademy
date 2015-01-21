using System;
using System.Numerics;

/*
Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

class CalculateNFactorialKFactorial
{
    static void Main()
    {
        Console.Write("Enter the first integer n (1 < k < n < 100): ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer k (1 < k < n < 100): ");
        int secondNumber = int.Parse(Console.ReadLine());

        BigInteger sum = 0;

        sum = Factorial(firstNumber) / Factorial(secondNumber);

        Console.WriteLine("Result: " + sum);
    }

    static BigInteger Factorial(long number)
    {
        if (number <= 1)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

