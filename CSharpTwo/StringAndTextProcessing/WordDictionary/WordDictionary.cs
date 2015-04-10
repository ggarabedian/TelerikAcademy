using System;
using System.Collections.Generic;

/*
A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
.NET	     Platform for applications from Microsoft
CLR	managed  Execution environment for .NET
namespace	 Hierarchical organization of classes
*/

class WordDictionary
{
    static void Main()
    {
        Console.Write("Enter word to explain: ");
        string input = Console.ReadLine();

        Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {".NET", "Platform for applications from Microsoft"},
                {"CLR managed", "Execution environment for .NET"},
                {"namespace", "Hierarchical organization of classes"}
            };

        if (dict.ContainsKey(input))
        {
            Console.WriteLine("I know this one! {0}." , dict[input]);
        }
        else
        {
            Console.WriteLine("I have no idea what are you talking about!");
        }
    }
}

