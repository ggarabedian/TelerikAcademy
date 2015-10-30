using System;

/*
Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter element to be found: ");
        int elementToBeFound = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        int min = 0;
        int max = arraySize;
        bool elementIsFound = false;
        int resultIndex = 0;

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Console.WriteLine("The sorted array: " + string.Join(", ", array));

        while (max >= min)
        {
            int mid = (min + max) / 2;
            if (array[mid] == elementToBeFound)
            {
                resultIndex = mid;
                elementIsFound = true;
                break;
            }
            else if (array[mid] < elementToBeFound)
            {
                min = mid + 1;
            }
            else
            {
                max = mid - 1;
            }
        }

        if (elementIsFound == true)
        {
            Console.WriteLine("Element is found at index [{0}]", resultIndex);
        }
        else
        {
            Console.WriteLine("Element not found");
        }
    }
}


