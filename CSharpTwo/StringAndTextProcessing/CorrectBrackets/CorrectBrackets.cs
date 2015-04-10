using System;
using System.Text;

/*
Write a program to check if in a given expression the brackets are put correctly.
*/

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression to be checked: ");
        string input = Console.ReadLine();
        bool result = CheckBrackets(input);
        Console.WriteLine("The brackets in the expression are placed correctly: " + result);
    }

    static bool CheckBrackets(string str)
    {
        int counter = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (counter == 0 && str[i] == ')')
            {
                return false;
            }
            else if(str[i] == '(' && str[i+1] == ')')
            {
                return false;
            }
            else
            {
                if (str[i] == '(')
                {
                    counter++;
                }
                else if(str[i] == ')')
                {
                    counter--;
                }
            }
        }

        if (counter == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

