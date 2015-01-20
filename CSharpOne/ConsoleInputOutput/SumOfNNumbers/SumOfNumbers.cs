using System;

/*
Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
*/

class SumOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a amount of numbers: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        decimal sum = 0;

        Console.WriteLine("Enter {0} numbers: ", amount);
        for (int i = 0; i < amount; i++)
        {
            sum += decimal.Parse(Console.ReadLine());
        }

        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}

