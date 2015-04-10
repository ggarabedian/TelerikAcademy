using System;
using System.Collections.Generic;
using System.IO;

/*
Write a program that compares two text files line by line and prints the number of lines that are the same and the number 
of lines that are different. Assume the files have equal number of lines.
*/

class CompareTextFiles
{
    static void Main()
    {
        StreamReader firstReader = new StreamReader("../../FirstText.txt");
        StreamReader secondReader = new StreamReader("../../SecondText.txt");
        int lineCounter = 1;

        using (firstReader)
        {
            using (secondReader)
            {
                string firstTextLine = firstReader.ReadLine();
                string secondTextLine = secondReader.ReadLine();

                List<int> sameLinesList = new List<int>();
                List<int> differentLinesList = new List<int>();

                while (firstTextLine != null)
                {
                    if (firstTextLine.Equals(secondTextLine))
                    {
                        sameLinesList.Add(lineCounter);
                    }
                    else
                    {
                        differentLinesList.Add(lineCounter);
                    }

                    lineCounter++;
                    firstTextLine = firstReader.ReadLine();
                    secondTextLine = secondReader.ReadLine();
                }

                Console.WriteLine("Same lines in both texts: {0}", string.Join(", ", sameLinesList));
                Console.WriteLine("Different lines i n both texts: {0}", string.Join(", ", differentLinesList));
            }
        }
    }
}

