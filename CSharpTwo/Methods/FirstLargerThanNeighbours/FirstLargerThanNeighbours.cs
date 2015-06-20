using System;

/*
Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise
*/

class FirstLargerThanNeighbours
{

    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(FindIndex(array)); 
    }

    static int FindIndex(int[] someArray)
    {
        int index = -1;
        for (int i = 1; i < someArray.Length - 1; i++)
        {
            if (someArray[i] > someArray[i-1] && someArray[i] > someArray[i+1])
            {
                index = i;
            }
        }
        return index;
    }

}

