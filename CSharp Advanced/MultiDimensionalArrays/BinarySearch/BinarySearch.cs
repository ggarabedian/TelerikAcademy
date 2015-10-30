using System;

/*
Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the 
method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter number K: ");
        int K = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        int tempK = K;
        while (Array.BinarySearch(array, tempK) < 0)
        {
            tempK--;
        }

        Console.WriteLine("Largest number in the array less or equal to {0} is: {1}", K, tempK);
    }
}

