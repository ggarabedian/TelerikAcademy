using System;

/*
Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/

class AppearanceCount
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter number to search for: ");
        int number = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The number {0} appears {1} times in the array!", number, AppeareancesCount(array, number));
    }

    static int AppeareancesCount(int[] array, int number)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (number == array[i])
            {
                counter++;
            }
        }
        return counter;
    }
}

