using System;

/*
Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a number in hexadecimal format: ");
        string input = Console.ReadLine();

        char[] inputArray = input.ToCharArray();

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

            result += (long)(curElement * Math.Pow(16, power));
            power--;
        }
        Console.WriteLine("Decimal: " + result);
    }
}

