using System;

/*
Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        int trailingZeroes = 0;
        int power = 1;
        int divisor = 0;

        while (divisor < input)
        {
            divisor = (int)Math.Pow(5, power);
            trailingZeroes += input / divisor;
            power++;
        }

        Console.WriteLine("Trailing Zeroes: " + trailingZeroes);
    }
}

