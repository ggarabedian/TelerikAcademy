using System;

/*
Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

class SelectionSort
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        int minElement;

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The unsorted array: " + string.Join(", ", array));

        for (int i = 0; i < arraySize - 1; i++)
        {
            minElement = i;

            for (int j = i + 1; j < arraySize; j++)
            {
                if (array[j] < array[minElement])
                {
                    minElement = j;
                }
            }

            if (minElement != i)
            {
                int temp = array[i];
                array[i] = array[minElement];
                array[minElement] = temp;
            }
        }

        Console.WriteLine("The sorted array: " + string.Join(", ", array));
    }
}
