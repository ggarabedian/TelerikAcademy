using System;

/*
Write a program to convert decimal numbers to their hexadecimal representation.
*/

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Enter a number in decimal format: ");
        long input = long.Parse(Console.ReadLine());

        

        Console.WriteLine("Hexadecimal format: " + ConvertDecimalToHexadecimal(input));
    }

    static string ConvertDecimalToHexadecimal(long number)
    {
        string result = "";
        char charElement = char.MinValue;

        while (number > 0)
        {
            long curElement = number % 16;
            if (curElement > 9)
            {
                switch (curElement)
                {
                    case 10: charElement = 'A'; break;
                    case 11: charElement = 'B'; break;
                    case 12: charElement = 'C'; break;
                    case 13: charElement = 'D'; break;
                    case 14: charElement = 'E'; break;
                    case 15: charElement = 'F'; break;
                }
                result += charElement;
            }
            else
            {
                result += curElement.ToString();
            }
            number /= 16;
        }

        char[] temp = result.ToCharArray();
        Array.Reverse(temp);
        result = new string(temp);

        return result;
    }
}

