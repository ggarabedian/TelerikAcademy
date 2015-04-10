using System;
using System.Collections.Generic;
using System.Linq;
/*
Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words, separated by space: ");
        string input = Console.ReadLine();

        string[] words = input.Split(' ').ToArray();

        List<string> wordsInOrder = words.OrderBy(x => x).ToList();

        Console.WriteLine("The words in alphabetical order:\n" + string.Join("\n", wordsInOrder));
    }
}

