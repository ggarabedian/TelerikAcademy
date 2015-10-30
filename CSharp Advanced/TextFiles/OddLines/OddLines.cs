using System;
using System.IO;

/*
Write a program that reads a text file and prints on the console its odd lines.
*/

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../RandomText.txt");

        using (reader)
        {
            int lineCounter = 0;
            string curLine = reader.ReadLine();

            while (true)
            {
                if (curLine == null)
                {
                    break;
                }

                if (lineCounter % 2 == 1)
                {
                    Console.WriteLine(curLine);
                }

                lineCounter++;
                curLine = reader.ReadLine();
            }
        }
    }
}

