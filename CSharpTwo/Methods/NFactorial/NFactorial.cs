using System;
using System.Numerics;

/*
Write a program to calculate n! for each n in the range [1..100].
*/

class NFactorial
{
    static void Main()
    {
        int[] array = new int[100];

        for (int i = 0; i < 100; i++)
        {
            array[i] = i + 1;
            BigInteger result = Factorial(array[i]);
            Console.WriteLine(result);
        }
    }

    static BigInteger Factorial(int number)
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

