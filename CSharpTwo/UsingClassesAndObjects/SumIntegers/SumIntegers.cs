using System;

/*
You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
*/

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter sequence of positive numbers separated by space: ");
        string input = Console.ReadLine();

        Console.WriteLine(CalculateSum(input));
    }

    static long CalculateSum(string str)
    {
        long result = 0;
        string[] strInput = str.Split();

        for (int i = 0; i < strInput.Length; i++)
        {
            result += int.Parse(strInput[i]);
        }

        return result;
    }
}

