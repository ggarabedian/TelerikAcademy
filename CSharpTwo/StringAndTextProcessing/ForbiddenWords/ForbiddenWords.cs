using System;
using System.Text;
using System.Collections.Generic;

/*
We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that 
replaces the forbidden words with asterisks.
Example text: 
Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
Forbidden words: PHP, CLR, Microsoft
The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

class ForbiddenWords
{
    static void Main()
    {
        Console.WriteLine("Enter forbidden words separated by comma: ");
        string forbidden = Console.ReadLine();
        Console.WriteLine("Enter text containing forbidden words: ");
        string input = Console.ReadLine();

        string[] forbiddenArray = forbidden.Split(new char[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        string[] textArray = input.Split(new char[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < forbiddenArray.Length; i++)
        {
            for (int j = 0; j < textArray.Length; j++)
            {
                if (textArray[j] == forbiddenArray[i])
                {
                    input = input.Replace(forbiddenArray[i], new string('*', forbiddenArray[i].Length));
                }
            }
        }

        Console.WriteLine("The the new text is: \n" + input);
    }
}

