using System;
using System.Collections.Generic;

/*
Write a program that reads a string from the console and lists all different words in the string along with 
information how many times each word is found.
*/

class WordsCount
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        string[] splitText = input.Split(' ');

        Dictionary<string, int> charCount = new Dictionary<string, int>();

        foreach (string word in splitText)
        {
            if (charCount.ContainsKey(word))
            {
                charCount[word] += 1;
            }
            else
            {
                charCount.Add(word, 1);
            }
        }

        foreach (var element in charCount)
        {
            Console.WriteLine("\"{0}\" is found {1} time(s)!", element.Key, element.Value);
        }
    }
}

