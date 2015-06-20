using System;

/*
Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter amount of elements to sum: ");
        int elementsCount = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];
        int maxSum = 0;

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.Write("The {0} elements that create the maximal sum are: ", elementsCount);
        for (int i = 0; i < elementsCount; i++)
        {
            maxSum += array[i];
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("and the maximal sum is: " + maxSum);
    }
}