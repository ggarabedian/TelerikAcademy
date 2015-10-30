using System;
using System.IO;

/*
Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/

class ReplaceSubString
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OriginalText.txt");
        StreamWriter writer = new StreamWriter("../../ReplacedText.txt");

        using (reader)
        {
            using (writer)
            {
                string curLine = reader.ReadLine();

                while (curLine != null)
                {
                    string replacedLine = curLine.Replace("start", "finish");
                    writer.WriteLine(replacedLine);

                    curLine = reader.ReadLine();
                }
            }
        }
        Console.WriteLine("Replacing completed!");
    }
}
