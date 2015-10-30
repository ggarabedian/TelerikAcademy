using System;
using System.Text;

/*
Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
*/

class UnicodeCharactes
{
    static void Main()
    {
        Console.Write("Enter text to be converted: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        foreach (char ch in input)
        {
            result.AppendFormat("\\u{0:X4}", (int)ch);
        }

        Console.WriteLine(result.ToString());
    }
}

