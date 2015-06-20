using System;

/*
Write a program that compares two char arrays lexicographically (letter by letter).
*/


class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int counter = 0;

        char[] firstArray = new char[arraySize];
        char[] secondArray = new char[arraySize];

        Console.WriteLine("Enter chars for the first array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            firstArray[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter chars for the second array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            secondArray[i] = char.Parse(Console.ReadLine());;
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