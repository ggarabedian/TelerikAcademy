using System;
using System.Collections.Generic;
using System.Text;

/*  
Write a program that reverses the words in given sentence.
Example: input: C# is not C++, not PHP and not Delphi! // output: Delphi not and PHP, not C++ not is C#!
 */

class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter sentence to be reversed: ");
        string input = Console.ReadLine();

        string[] textArr = input.Split(new char[] { ' ', '!', '?', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

        List<char> symbols = new List<char>();
        StringBuilder reversedText = new StringBuilder();

        for (char ch = '0'; ch <= 'z'; ch++)
        {
            if ((ch >= 'a' && ch <= 'z') ||
                (ch >= 'A' && ch <= 'Z') ||
                (ch >= '0' && ch <= '9'))
            {
                symbols.Add(ch);
            }
        }
        symbols.Add('#');
        symbols.Add('+');

        string[] punctuationMarks = input.Split(symbols.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(textArr);

        for (int i = 0; i < punctuationMarks.Length; i++)
        {
            if (i == 0 || punctuationMarks[i] == "." || punctuationMarks[i] == "!")
            {
                textArr[i].Replace(textArr[i][0], Char.ToUpper(textArr[i][0]));
            }
            reversedText.Append(textArr[i]);
            reversedText.Append(punctuationMarks[i]);
        }
        Console.WriteLine("The reversed text: " + reversedText.ToString());
    }
}
