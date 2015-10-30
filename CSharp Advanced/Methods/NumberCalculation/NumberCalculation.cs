using System;
using System.Linq;

/*
Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
Use generic method (read in Internet about generic methods in C#).
*/

class NumberCalculation
{
    static void Main()
    {
        Console.Write("Enter a sequence of integer numbers separated by space: ");
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("The minimum number in the sequence is: {0}", FindMinimum(input));
        Console.WriteLine("The maximum number in the sequence is: {0}", FindMaximum(input));
        Console.WriteLine("The average of the sequence is: {0:N2}", FindAverage(input));
        Console.WriteLine("The sum of the sequence is: {0}", FindSum(input));
        Console.WriteLine("The product of the sequence is: {0}", FindProduct(input));

        Console.WriteLine(new string('-', 50));
        decimal[] decimalArray = new decimal[] { 2.34m, 34.66m, 1.32m, 35.90m, 7.33m };

        Console.WriteLine("The minimum number in the sequence is: {0}", FindMinimum(decimalArray));
        Console.WriteLine("The maximum number in the sequence is: {0}", FindMaximum(decimalArray));
        Console.WriteLine("The average of the sequence is: {0:N2}", FindAverage(decimalArray));
        Console.WriteLine("The sum of the sequence is: {0}", FindSum(decimalArray));
        Console.WriteLine("The product of the sequence is: {0:N2}", FindProduct(decimalArray));
    }

    static T FindMinimum<T>(params T[] arr)
    {
        return arr.Min();
    }

    static T FindMaximum<T>(params T[] arr)
    {
        return arr.Max();
    }

    static decimal FindAverage<T>(params T[] arr)
    {
        dynamic result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result/(decimal)arr.Length;
    }

    static T FindSum<T>(params T[] arr)
    {
        dynamic result = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            result += arr[i];
        }
        return result;
    }

    static T FindProduct<T>(params T[] arr)
    {
        dynamic result = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            result *= arr[i];
        }
        return result;
    }
}

