using System;

/*
Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality. 
*/

class Sort3NumbersWithNestedIf
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        decimal thirdNumber = decimal.Parse(Console.ReadLine());

        string result = "";

        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            result += firstNumber.ToString() + " ";
            if (secondNumber > thirdNumber)
            {
                result += secondNumber.ToString() + " " + thirdNumber.ToString();
            }
            else
            {
                result += thirdNumber.ToString() + " " + secondNumber.ToString();
            }
        }

        if (secondNumber > firstNumber && secondNumber > thirdNumber)
        {
            result += secondNumber.ToString() + " ";
            if (firstNumber > thirdNumber)
            {
                result += firstNumber.ToString() + " " + thirdNumber.ToString();
            }
            else
            {
                result += thirdNumber.ToString() + " " + firstNumber.ToString();
            }
        }

        if (thirdNumber > firstNumber && thirdNumber > secondNumber)
        {
            result += thirdNumber.ToString() + " ";
            if (firstNumber > secondNumber)
            {
                result += firstNumber.ToString() + " " + secondNumber.ToString();
            }
            else
            {
                result += secondNumber.ToString() + " " + firstNumber.ToString();
            }
        }
        Console.WriteLine(result);
    }
}

