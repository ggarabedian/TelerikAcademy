using System;

/*
Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
*/

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        firstNumber = Math.Abs(firstNumber);
        secondNumber = Math.Abs(secondNumber);

        Console.WriteLine("GCD: " + GreatestCommonDivisor(firstNumber, secondNumber));
    }

    static int GreatestCommonDivisor(int firstValue, int secondValue)
    {
        while (firstValue != 0 && secondValue != 0)
        {
            if (firstValue > secondValue)
            {
                firstValue -= secondValue;
            }
            else
            {
                secondValue -= firstValue;
            }
        }
        return Math.Max(firstValue, secondValue);
    }
}

