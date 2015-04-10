using System;
using System.IO;
using System.Collections.Generic;

/*
Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../RandomText.txt");
        var listOfEvenLines = new List<string>();
        int lineCounter = 1;

        using (reader)
        {
            string curLine = reader.ReadLine();

            while (curLine != null)
            {
                if (lineCounter % 2 == 0)
                {
                    listOfEvenLines.Add(curLine);
                }

                lineCounter++;
                curLine = reader.ReadLine();
            }
        }

        StreamWriter writer = new StreamWriter("../../RandomText.txt");
        using (writer)
        {
            foreach (var line in listOfEvenLines)
            {
                writer.WriteLine(line);
            }
        }
        Console.WriteLine("Odd lines removed from text!");
    }
}

