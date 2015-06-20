using System;

/*
Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/

class IndexOfLetters
{
    static void Main()
    {
        int[] array = new int[26];

        for (char chars = 'A'; chars < 'Z'; chars++)
        {
            array[chars - 65] = chars;
        }

        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        foreach (var letter in input)
        {
            Console.WriteLine("Letter {0}  =>  Index {1}", letter, Array.IndexOf(array, char.ToUpperInvariant(letter)));
        }
    }
}