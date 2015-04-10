using System;

/*
Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

class Palindromes
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        string[] textSplit = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] palindromes = Array.FindAll(textSplit, IsPalindromes);

        Console.WriteLine("Palindromes: ");
        foreach (string pal in palindromes)
        {
            Console.WriteLine(pal);
        }
    }

    static bool IsPalindromes(string str)
    {
        bool result = false;
        char[] charArr = str.ToCharArray();

        for (int i = 0; i < charArr.Length / 2; i++)
        {
            result = charArr[i] == charArr[charArr.Length - i - 1];
            if (!result)
            {
                break;
            }
        }

        return result;
    }
}

