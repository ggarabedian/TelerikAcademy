using System;

/*
Write a program that sorts an array of strings using the Quick sort algorithm (find it in Wikipedia).
*/

class MergeSort
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Array before sorting: {0}", string.Join(", ", array));

        QuickSort(array, 0, arraySize - 1);

        Console.WriteLine("Array after sorting: {0}", string.Join(", ", array));
    }

    static void QuickSort(int[] array, int left, int right)
    {
        int tempLeft = left;
        int tempRight = right;
        int middle = array[(left + right) / 2];

        while (tempLeft <= tempRight)
        {
            while (array[tempLeft].CompareTo(middle) < 0)
            {
                tempLeft++;
            }

            while (array[tempRight].CompareTo(middle) > 0)
            {
                tempRight--;
            }

            if (tempLeft <= tempRight)
            {
                int temp = array[tempLeft];
                array[tempLeft] = array[tempRight];
                array[tempRight] = temp;

                tempLeft++;
                tempRight--;
            }
        }

        if (left < tempRight)
        {
            QuickSort(array, left, tempRight);
        }

        if (tempLeft < right)
        {
            QuickSort(array, tempLeft, right);
        }
    }
}
