using System;
using System.Numerics;

/*
In combinatorics, the number of ways to choose k different members out of a group of n different elements 
(also known as the number of combinations) is calculated by the following formula: n! / k!*(n-k)! For example, 
there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program 
that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

class NumberOfCombinations
{
    static void Main()
    {
        Console.Write("Enter the first integer n (1 < k < n < 100): ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second integer k (1 < k < n < 100): ");
        int secondNumber = int.Parse(Console.ReadLine());

        BigInteger result = Factorial(firstNumber) / (Factorial(secondNumber) * Factorial(firstNumber - secondNumber));

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
