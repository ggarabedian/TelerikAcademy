using System;

/*
Write a program that finds the maximal sequence of equal elements in an array.
*/

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        int currentNumber = 0;
        int seqLength = 1;

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
            if (array[i-1] == array[i])
            {
                seqLength++;
                currentNumber = array[i];
                if (seqLength > bestSeq)
                {
                    bestNumber = currentNumber;
                    bestSeq = seqLength;
                }
            }
            else
            {
                seqLength = 1;
                currentNumber = 0;
            }
        }
        
        if (bestSeq == 1)
        {
            Console.WriteLine("This array does not contain sequence of equal elements.");
        }
        else
        {
            for (int i = 0; i < bestSeq; i++)
            {
                Console.Write("{0} ", bestNumber);
            }
            Console.WriteLine();
        }      
    }
}

