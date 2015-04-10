using System;
using System.IO;

/*
Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/

class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OriginalText.txt");
        StreamWriter writer = new StreamWriter("../../TextWithLineNumbers.txt");
        int lineNumber = 1;

        using (reader)
        {

            using (writer)
            {
                string curLine = reader.ReadLine();

                while (curLine != null)
                {
                    writer.WriteLine("Line {0:D2}: {1}", lineNumber, curLine);
                    curLine = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}

