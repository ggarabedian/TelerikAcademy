using System;
using System.Collections.Generic;

/*
Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder 
of the division by 5 is 0.
*/

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter the first positive integer: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the second positive integer: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int counter = 0;
        List<int> numbers = new List<int>();

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
                numbers.Add(i);
            }
        }
        Console.WriteLine("Numbers between {0} and {1} which reminder of the division by 5 is 0: {2}", firstNumber, secondNumber, counter);
        Console.WriteLine(string.Join(", ", numbers));
    }
}
