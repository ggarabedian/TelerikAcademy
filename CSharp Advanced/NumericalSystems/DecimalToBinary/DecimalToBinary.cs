using System;

/*
Write a program to convert decimal numbers to their binary representation.
*/

class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a number in decimal format: ");
        long input = long.Parse(Console.ReadLine());       

        Console.WriteLine("Binary format: " + ConvertDecimalToBinary(input));
    }

    static string ConvertDecimalToBinary(long number)
    {
        string result = "";

        if (number == 0)
        {
            result = "0";
        }
        else
        {
            while (number > 0)
            {
                result += (number % 2);
                number /= 2;
            }
        }

        char[] temp = result.ToCharArray();
        Array.Reverse(temp);
        result = new string(temp);

        return result;
    }
}

