using System;
using System.IO;
using System.Text.RegularExpressions;

/*
Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/

class RemoveWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OriginalText.txt");
        StreamWriter writer = new StreamWriter("../../ResultingText.txt");

        try
        {
            string words = String.Join(" ", File.ReadAllLines("../../WordsToRemove.txt"));
            string[] wordsToRemove = words.Split(' ');
            
            using (reader)
            {
                string curLine = reader.ReadLine();

                using (writer)
                {
                    while (curLine != null)
                    {
                        for (int i = 0; i < wordsToRemove.Length; i++)
                        {
                            curLine = Regex.Replace(curLine, "\\b" + wordsToRemove[i] + "\\b", "");
                        }
                        writer.WriteLine(curLine);
                        curLine = reader.ReadLine();
                    }
                }
            }
        }

        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("All words given in the list are now deleted from the text!");
    }
}

