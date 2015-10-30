using System;
using System.Text.RegularExpressions;

/*
Write a program that reads a string from the console and replaces all series of consecutive identical letters 
with a single one.
*/

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        Console.WriteLine("The result: " + Regex.Replace(input, @"(.)(\1)+", "$1"));
    }
}

