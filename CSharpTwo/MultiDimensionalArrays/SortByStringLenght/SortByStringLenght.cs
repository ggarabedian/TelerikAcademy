using System;
using System.Linq;
using System.Collections.Generic;

/*
You are given an array of strings. Write a method that sorts the array by the length of its elements 
(the number of characters composing them).
*/

class SortByStringLenght
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        List<string> unsortedList = new List<string>();

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Array[{0}] = ", i);
            unsortedList.Add(Console.ReadLine());
        }

        Console.WriteLine(new string('-', 50));
        Console.WriteLine("Unsorted array: {0}", string.Join(" ", unsortedList));
        Console.WriteLine(new string('-', 50));
        Console.Write("Sorted array: ");
        foreach (string str in SortByTheLenghtOfElements(unsortedList))
        {
            Console.Write(str + " ");
        }
        Console.WriteLine();
    }

    static IEnumerable<string> SortByTheLenghtOfElements(IEnumerable<string> someList)
    {
        var sorted = from str in someList
                     orderby str.Length ascending
                     select str;
        return sorted;
    }
}

