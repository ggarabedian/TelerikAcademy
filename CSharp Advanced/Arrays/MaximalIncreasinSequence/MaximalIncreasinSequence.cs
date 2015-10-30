using System;

/*
Write a program that finds the maximal increasing sequence in an array.
*/

class MaximalIncreasinSequence
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        int currentNumber = 0;
        int curSeq = 1;

        int bestNumber = 0;
        int bestSeq = 1;

        Console.WriteLine("Enter numbers for the array: ");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("array[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < arraySize; i++)
        {
            if (array[i - 1] + 1 == array[i])
            {
                curSeq++;
                currentNumber = array[i];
                if (curSeq > bestSeq)
                {
                    bestNumber = currentNumber - curSeq + 1;
                    bestSeq = curSeq;
                }
            }
            else
            {
                curSeq = 1;
                currentNumber = 0;
            }
        }

        if (bestSeq == 1)
        {
            Console.WriteLine("This array does not contain sequence of increasing elements.");
        }
        else
        {
            for (int i = 0; i < bestSeq; i++)
            {
                Console.Write("{0} ", bestNumber + i);
            }
            Console.WriteLine();
        }      
    }
}
