using System;
using System.IO;

/*
Write a program that concatenates two text files into another text file.
*/

class ConcatenateTextFiles
{
    static string readPath = "../../FirstText.txt";
    static string writePath = "../../ConcatenatedText.txt";

    static void Main()
    {
       ConcatenateTexts(readPath, writePath);

        readPath = "../../SecondText.txt";
        ConcatenateTexts(readPath, writePath);
    }

    static void ConcatenateTexts(string readPath, string writePath)
    {
        StreamReader reader = new StreamReader(readPath);
        StreamWriter writer = new StreamWriter(writePath, true);

        using (reader)
        {

            using (writer)
            {
                string curLine = reader.ReadLine();

                while (curLine != null)
                {
                    writer.WriteLine(curLine);
                    curLine = reader.ReadLine();
                }

            }
        }
    }
}

