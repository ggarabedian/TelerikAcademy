using System;

/*
Write a program that finds the biggest of three numbers.
*/

class BiggestOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        decimal biggestNumber = Math.Max(firstNumber, secondNumber);
        biggestNumber = Math.Max(biggestNumber, thirdNumber);

        Console.WriteLine(biggestNumber);
    }
}
