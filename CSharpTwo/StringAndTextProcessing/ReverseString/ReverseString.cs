using System;
using System.Text;

/*
Write a program that reads a string, reverses it and prints the result at the console.
*/

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string to be reversed: ");
        string input = Console.ReadLine();
        string result = StringReverse(input);
        Console.WriteLine("The string reversed: " + result);
    }

    static string StringReverse(string str)
    {
        StringBuilder result = new StringBuilder();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            result.Append(str[i]);
        }

        return result.ToString();
    }
}

