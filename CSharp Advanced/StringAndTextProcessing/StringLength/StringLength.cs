using System;
using System.Text;

/*
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20,
the rest of the characters should be filled with *. Print the result string into the console.
*/

class StringLength
{
    static void Main()
    {
        Console.Write("Enter string with maximum 20 characters: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder(input);

        if (input.Length < 20)
        {
            for (int i = input.Length; i < 20; i++)
            {
                result.Append("*");
            }
        }

        Console.WriteLine("The resulting string: " + result.ToString());
    }
}

