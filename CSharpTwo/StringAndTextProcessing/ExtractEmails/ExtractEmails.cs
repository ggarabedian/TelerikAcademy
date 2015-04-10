using System;
using System.Text;
using System.Text.RegularExpressions;

/*
Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string input = Console.ReadLine();

        string[] textSplit = input.Split(new[] { " ", ";", ",", ". " }, StringSplitOptions.RemoveEmptyEntries);
        string[] emails = Array.FindAll(textSplit, IsValidEmail);

        Console.WriteLine("Valid e-mails: ");
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }
    }

    static bool IsValidEmail(string email)
    {
        const string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                               @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                               @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

        bool result = new Regex(pattern).IsMatch(email);
        return result;
    }
}
