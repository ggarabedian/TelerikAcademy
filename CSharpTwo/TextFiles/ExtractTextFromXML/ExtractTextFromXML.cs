using System;
using System.IO;

/*
Write a program that extracts from given XML file all the text without the tags.
Example:
<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
*/

class ExtractTextFromXML
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../XMLFile.txt");
        string extractedText = string.Empty;

        using (reader)
        {
            string curLine = reader.ReadLine();

            while (curLine != null)
            {

                for (int i = 1; i < curLine.Length; i++)
                {

                    if (curLine[i - 1] == '>')
                    {

                        while (curLine[i] != '<')
                        {
                            extractedText += curLine[i];
                            i++;
                        }

                        if (extractedText != string.Empty)
                        {
                            Console.WriteLine(extractedText.TrimStart(' '));
                            extractedText = string.Empty;
                        }
                    }
                }

                curLine = reader.ReadLine();
            }
        }
    }
}

