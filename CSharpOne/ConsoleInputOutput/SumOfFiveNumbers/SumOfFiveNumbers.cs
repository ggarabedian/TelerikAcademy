using System;

/*
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers separated by space: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Convert.ToInt32(numbers[i]);
        }

        Console.WriteLine("The sum of the numbers is: " + sum);
    }
}
