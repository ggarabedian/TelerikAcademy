using System;

/*
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
 */

class BinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string input = Console.ReadLine();
        decimal inputLong = decimal.Parse(input);

        decimal tempNumber = inputLong;
        long result = 0;
        

        for (int i = 0; i < input.Length; i++)
        {
            decimal curElement = tempNumber % 10;
            result += (long)curElement * (long)Math.Pow(2, i);
            tempNumber /= 10;
        }
        Console.WriteLine("Decimal: " + result);
    }
}

