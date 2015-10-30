using System;
using System.Text.RegularExpressions;

/*
Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
*/

class ExtractTextFromHTML
{
    static void Main()
    {
        string html = @"<html><head><title>News</title></head> <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body> </html>";

        MatchCollection matchCol = Regex.Matches(html, @"((?<=^|>)[^><]+?(?=<|$))");
        int counter = 1;

        foreach (Match m in matchCol)
        {
            if (counter == 1)
            {
                Console.WriteLine("Title: " + m);
                Console.Write("Text:");
            }
            else
            {
                Console.Write(m + " ");
            }
            counter++;
        }

        Console.WriteLine();
    }
}

