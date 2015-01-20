using System;

/*
Write a program that reads 3 real numbers from the console and prints their sum.
*/

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        decimal sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("Sum of the three numbers is: " + sum);
    }
}