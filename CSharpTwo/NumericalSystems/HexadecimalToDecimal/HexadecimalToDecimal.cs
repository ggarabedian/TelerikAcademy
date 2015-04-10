using System;

/*
Write a program to convert hexadecimal numbers to their decimal representation.
 */

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a number in hexadecimal format: ");
        string input = Console.ReadLine();

        
        Console.WriteLine("Decimal format: " + ConvertHexadecimalToDecimal(input));
    }

    static long ConvertHexadecimalToDecimal(string str)
    {
        char[] inputArray = str.ToCharArray();

        long result = 0;
        long curElement = 0;
        long power = inputArray.Length - 1;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i] - '0' > 9)
            {
                switch (inputArray[i])
                {
                    case 'A': curElement = 10; break;
                    case 'B': curElement = 11; break;
                    case 'C': curElement = 12; break;
                    case 'D': curElement = 13; break;
                    case 'E': curElement = 14; break;
                    case 'F': curElement = 15; break;
                }
            }
            else
            {
                curElement = inputArray[i] - '0';
            }

            result += (long)(curElement * RaiseToPower(16, power));
            power--;
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