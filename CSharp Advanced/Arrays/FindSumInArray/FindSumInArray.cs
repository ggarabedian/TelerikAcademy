using System;

/*
Write a program that finds in given array of integers a sequence of given sum S (if present).
*/

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter sum to be found: ");
        int sumToBeFound = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        int startIndex = 0;
        int endIndex = 0;
        int sum = 0;
        bool seqExist = false;

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize; i++)
        {

            for (int j = i; j < arraySize; j++)
            {

                sum += array[j];
                if (sum == sumToBeFound)
                {
                    seqExist = true;
                    startIndex = i;
                    endIndex = j;
                }
            }

            sum = 0;
        }

        if (seqExist)
        {
            Console.Write("The elements that create the maximal sum are: ");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        else
        {
            Console.Write("There are no elements that create that sum.");
        }
        Console.WriteLine();
        
    }
}


