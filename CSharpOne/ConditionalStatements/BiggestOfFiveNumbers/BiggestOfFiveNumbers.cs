using System;

/*
Write a program that finds the biggest of five numbers by using only five if statements.
*/

class BiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        decimal fourthNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        decimal fifthNumber = decimal.Parse(Console.ReadLine());

        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            Console.WriteLine(thirdNumber);
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            Console.WriteLine(fourthNumber);
        }
        else
        {
            Console.WriteLine(fifthNumber);
        }
    }
}
