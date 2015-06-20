using System;

/*
Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter position to be checked: ");
        int position = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The element at index {0} is larger than it's neighbour(s): {1}", position, LargerThanNeighbour(array, position));
    }

    static bool LargerThanNeighbour(int[] array, int position)
    {
        bool result;

        if (position == 0)
        {
            result = array[position] > array[position + 1];
        }
        else if (position == array.Length - 1)
        {
            result = array[position] > array[position - 1];
        }
        else
        {
            result = array[position] > array[position - 1] && array[position] > array[position + 1];
        }
        
        return result;
    }
}
