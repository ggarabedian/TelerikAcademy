using System;
using System.IO;
using System.Collections.Generic;

/*
Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
*/

class SaveSortedNames
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../ListOfNames.txt");
        StreamWriter writer = new StreamWriter("../../SortedListOfNames.txt");
        var listOfNames = new List<string>();

        using (reader)
        {
            string curName = reader.ReadLine();

            while (curName != null)
            {
                listOfNames.Add(curName);

                curName = reader.ReadLine();
            }

            listOfNames.Sort();

            using (writer)
            {
                foreach (var name in listOfNames)
                {
                    writer.WriteLine(name);
                }
            }
        }
        Console.WriteLine("Sorting Complete!");
    }
}

