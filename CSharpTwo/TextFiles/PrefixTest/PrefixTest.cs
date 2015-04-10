using System;
using System.IO;
using System.Text.RegularExpressions;

/*
Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
*/

class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OriginalText.txt");
        StreamWriter writer = new StreamWriter("../../ChangedText.txt");

        using (reader)
        {
            using (writer)
            {
                string curLine = reader.ReadLine();
                while (curLine != null)
                {
                    curLine = Regex.Replace(curLine, @"\btest\w*\b", string.Empty);
                    writer.WriteLine(curLine);
                    curLine = reader.ReadLine();
                }
            }
        }
        Console.WriteLine(@"All words starting with the preffix ""test"" are removed.");
    }
}

