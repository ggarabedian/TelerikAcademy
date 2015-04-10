using System;
using System.Text;

/*
You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> 
to upper-case. The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

class ParseTags
{
    static void Main()
    {
        Console.WriteLine("Enter text to be changed: ");
        string input = Console.ReadLine();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {

            if (input.Length - i >= 8 && input.Substring(i, 8) == "<upcase>")
            {
                i += 8;
                while (input.Substring(i, 9) != "</upcase>")
                {
                    result.Append(Char.ToUpper(input[i]));
                    i++;
                }
                i += 8;
            }

            else
            {
                result.Append(input[i]);
            }          
        }

        Console.WriteLine("The changed string: \n" + result);
    }
}

