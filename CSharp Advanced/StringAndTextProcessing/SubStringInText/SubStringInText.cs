using System;
using System.Text;

/*
Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example: The target sub-string is "in". The text is as follows: 
"We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days."
The result is: 9
 */

class SubStringInText
{
    static void Main()
    {
        Console.Write("Enter sub-string to be found: ");
        string subStr = Console.ReadLine();
        Console.Write("Enter text in which to search the sub-string: ");
        string text = Console.ReadLine();

        int result = CountSubStringOccurrences(text, subStr);

        Console.WriteLine("The sub-string is found {0} times in this text!", result);
    }

    static int CountSubStringOccurrences(string text, string subStr)
    {
        int count = 0;
        int i = 0;
        while ((i = text.ToLower().IndexOf(subStr, i)) != -1)
        {
            i += subStr.Length;
            count++;
        }
        return count;
    }
}

