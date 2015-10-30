using System;
using System.Collections.Generic;

/*
Write a program that reads a string from the console and prints all different letters in the string along with 
information how many times each letter is found.
*/

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char ch in input)
        {
            if (!char.IsLetter(ch))
            {
                continue;
            }

            if (charCount.ContainsKey(ch))
            {
                charCount[ch] += 1;
            }
            else
            {
                charCount.Add(ch, 1);
            }
        }

        foreach (var element in charCount)
        {
            Console.WriteLine("\"{0}\" is found {1} time(s)!", element.Key, element.Value);
        }
    }
}

