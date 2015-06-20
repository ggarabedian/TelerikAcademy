using System;

/*
Write a program that finds the sequence of maximal sum in given array.
*/

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        int startIndex = 0;
        int tempStart = 0;
        int endIndex = 0;
        int sum = 0;
        int bestSum = int.MinValue;

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize; i++)
        {
            sum += array[i];
            if (sum > bestSum)
            {
                bestSum = sum;
                startIndex = tempStart;
                endIndex = i;
            }
            if (sum < 0)
            {
                sum = 0;
                tempStart = i + 1;
            }
        }

        Console.Write("The elements that create the maximal sum are: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine("and the maximal sum is: " + bestSum);
    }
}
