using System;

/*
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}.", Math.Max(firstNumber, secondNumber));
    }
}

