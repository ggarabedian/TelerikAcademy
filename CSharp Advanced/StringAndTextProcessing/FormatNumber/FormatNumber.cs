using System;

/*
Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific
notation. Format the output aligned right in 15 symbols.
*/

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("Dec: {0,15:D}", input);
        Console.WriteLine("Hex: {0,15:X}", input);
        Console.WriteLine("Per: {0,15:P}", input/100.0);
        Console.WriteLine("Sci: {0,15:E}", input);
    }
}

