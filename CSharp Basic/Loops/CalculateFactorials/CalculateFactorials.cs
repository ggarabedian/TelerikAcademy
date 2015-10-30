using System;

/*
Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
Use only one loop. Print the result with 5 digits after the decimal point.
*/

class CalculateFactorials
{
    static void Main()
    {
        Console.Write("Enter the first integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        double sum = 1;

        for (int i = 1; i <= firstNumber; i++)
        {
            sum += Factorial(i) / Math.Pow(secondNumber, i);
        }

        Console.WriteLine("Result: {0 : 0.00000}", sum);
    }

    static long Factorial(long number)
    {
        if (number <= 1)
            return 1;
        else
            return number * Factorial(number - 1);
    }
}

