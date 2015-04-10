using System;

/*
Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding 
tags [URL=…]…/URL].
input: <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
output: <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
*/

class ReplaceTags
{
    static void Main()
    {
        string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        string result = input;

        for (int i = 1; i < result.Length - 7; i++)
        {
            if (result.Substring(i, 7) == "<a href")
            {
                result = result.Replace("<a href", "[URL");
            }

            if (result.Substring(i, 4) == "</a>")
            {
                result = result.Replace("</a>", "[/URL]");
            }

            if (result.Substring(i, 2) == "\">")
            {
                result = result.Replace("\">", "]");
            }

            
        }

        Console.WriteLine("Original text:\n" + input);
        Console.WriteLine("Transformed text:\n" + result);
    }
}

