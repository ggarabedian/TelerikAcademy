using System;

/*
Write a program that reads two integer arrays from the console and compares them element by element.
*/

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int counter = 0;

        int[] firstArray = new int[arraySize];
        int[] secondArray = new int[arraySize];

        Console.WriteLine("Enter numbers for the first array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter numbers for the second array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arraySize; i++)
        {
            if (firstArray[i] == secondArray[i])
            {
                Console.WriteLine("At index [{0}] the arrays are equal", i);
                counter++;
            }
            else
            {
                Console.WriteLine("At index [{0}] the arrays are not equal", i);
            }
        }

        if (counter == arraySize)
        {
             Console.WriteLine("The two arrays are identical!");
        }
    }
}

