using System;

/*
Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number 
n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below.
*/

class MinMaxSumAndAverage
{
    static void Main()
    {
        Console.Write("Enter amount of numbers: ");
        int amount = int.Parse(Console.ReadLine());

        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int sum = 0;
        double average = 0.00d;

        for (int i = 0; i < amount; i++)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            minValue = Math.Min(minValue, number);
            maxValue = Math.Max(maxValue, number);
            sum += number;
        }
        average = (double)sum / amount;

        Console.WriteLine("Min Value: " + minValue);
        Console.WriteLine("Max Value: " + maxValue);
        Console.WriteLine("Sum Value: " + sum);
        Console.WriteLine("Average Value: {0 : 0.00}", average);

    }
}
