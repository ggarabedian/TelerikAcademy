using System;
using System.Numerics;

/*
In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
Write a program to calculate the nth Catalan number by given n (1 < n < 100).
*/

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n ( 1 < n < 100): ");
        int number = int.Parse(Console.ReadLine());

        BigInteger result = Factorial(2 * number) / (Factorial(number + 1) * Factorial(number));

        Console.WriteLine("Result: " + result);
    }

    static BigInteger Factorial(long number)
    {
        if (number <= 1)
            return 1;
        else
            return number * Factorial(number - 1);
    }
}

