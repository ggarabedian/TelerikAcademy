using System;
using System.IO;
using System.Text.RegularExpressions;

/*
Write a program that reads a list of words from the file words.txt and finds how many times each of the words is 
contained in another file test.txt. The result should be written in the file result.txt and the words should be 
sorted by the number of their occurrences in descending order. Handle all possible exceptions in your methods.
*/

class CountWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../OriginalText.txt");
        StreamWriter writer = new StreamWriter("../../WordsCount.txt");

        try
        {
            using (reader)
            {
                using (writer)
                {
                    string[] words = File.ReadAllLines("../../WordsToCount.txt");
                    int[] repeatCount = new int[words.Length];

                    string curLine = reader.ReadLine();

                    while (curLine != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            repeatCount[i] += Regex.Matches(curLine, @"\b" + words[i] + @"\b").Count;
                        }

                        curLine = reader.ReadLine();
                    }
                    Array.Sort(repeatCount, words);

                    for (int i = words.Length - 1; i >= 0; i--)
                    {
                        writer.WriteLine("{0}: {1}", words[i], repeatCount[i]);
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

        Console.WriteLine("Counting Complete!");
    }
}

