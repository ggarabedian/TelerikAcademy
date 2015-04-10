using System;
using System.Text;

/*
Write a program that extracts from a given text all sentences containing given word.
Example: The word is: in. The text is: 
We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

class ExtractSentence
{
    static void Main()
    {
        Console.Write("Enter sentences: ");
        string input = Console.ReadLine();

        int lastPointIndex = -1;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '.')
            {
                lastPointIndex = i;
            }

            if (input.Length - i > 4 && input.Substring(i, 4) == " in ")
            {
                int j = lastPointIndex + 1;

                while (input[j] != '.')
                {
                    result.Append(input[j]);
                    j++;
                }
                result.Append('.');

                lastPointIndex = j;
            }
        }

        Console.WriteLine(result.ToString());
    }
}

