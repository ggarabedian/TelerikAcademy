using System;

/*
Write a program to convert binary numbers to their decimal representation.
*/

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number in binary format: ");
        string input = Console.ReadLine();

        Console.WriteLine("Decimal format: " + ConvertBinaryToDecimal(input));
    }

    static long ConvertBinaryToDecimal(string str)
    {
        long longInput = long.Parse(str);
        long result = 0;

        for (int i = 0; i < str.Length; i++)
        {
            decimal curElement = longInput % 10;
            result += (long)curElement * RaiseToPower(2, i);
            longInput /= 10;
        }

        return result;
    }

    static long RaiseToPower(long number, long power)
    {
        long result = 1;

        while (power > 0)
        {
            result *= number;
            power--;
        }
        return result;
    }
}