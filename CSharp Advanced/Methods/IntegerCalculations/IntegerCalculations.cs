using System;
using System.Linq;

/*
Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/

class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter a sequence of integer numbers separated by space: ");
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine("The minimum number in the sequence is: {0}", FindMinimum(input));
        Console.WriteLine("The maximum number in the sequence is: {0}", FindMaximum(input));
        Console.WriteLine("The average of the sequence is: {0:N2}", FindAverage(input));
        Console.WriteLine("The sum of the sequence is: {0}", FindSum(input));
        Console.WriteLine("The product of the sequence is: {0}", FindProduct(input));
    }

    static int FindMinimum(params int[] arr)
    {
        return arr.Min();
    }

    static int FindMaximum(params int[] arr)
    {
        return arr.Max();
    }

    static decimal FindAverage(params int[] arr)
    {
        decimal result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result / (decimal)arr.Length;
    }

    static long FindSum(params int[] arr)
    {
        long result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result;
    }

    static long FindProduct(params int[] arr)
    {
        long result = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            result *= arr[i];
        }
        return result;
    }
}

