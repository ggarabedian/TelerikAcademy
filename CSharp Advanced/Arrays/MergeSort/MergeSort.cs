using System;

/*
Write a program that sorts an array of integers using the Merge sort algorithm (find it in Wikipedia).
*/

class MergeSort
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        int[] tempArray = new int[arraySize];

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array before sorting: {0}", string.Join(", ", array));

        SplitMerge(array, 0, arraySize, tempArray);

        Console.WriteLine("Array after sorting: {0}", string.Join(", ", array));
    }

    static void SplitMerge(int[] arrayToBeSorted, int start, int end, int[] tempArray)
    {
        if (end - start < 2)
        {
            return;
        }

        int middle = (end + start) / 2;
        SplitMerge(arrayToBeSorted, start, middle, tempArray);
        SplitMerge(arrayToBeSorted, middle, end, tempArray);
        Merge(arrayToBeSorted, start, middle, end, tempArray);
        CopyArray(tempArray, start, end, arrayToBeSorted);
    }

    static void Merge(int[] arrayToBeSorted, int start, int middle, int end, int[] tempArray)
    {
        int tempStart = start;
        int tempMiddle = middle;

        for (int i = start; i < end; i++)
        {
            if (tempStart < middle && (tempMiddle >= end || arrayToBeSorted[tempStart] <= arrayToBeSorted[tempMiddle]))
            {
                tempArray[i] = arrayToBeSorted[tempStart];
                tempStart = tempStart + 1;
            }
            else
            {
                tempArray[i] = arrayToBeSorted[tempMiddle];
                tempMiddle = tempMiddle + 1;
            }
        }
    }

    static void CopyArray(int[] tempArray, int start, int end, int[] arrayToBeSorted)
    {
        for (int i = start; i < end; i++)
        {
            arrayToBeSorted[i] = tempArray[i];
        }
    }
}