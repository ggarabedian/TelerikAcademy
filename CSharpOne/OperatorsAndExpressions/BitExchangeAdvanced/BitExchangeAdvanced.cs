using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter number to have bits exchanged (n): ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter first bit to be exchanged (p): ");
        int firstSeq = int.Parse(Console.ReadLine());
        Console.Write("Enter second bit to be exchanged (q): ");
        int secondSeq = int.Parse(Console.ReadLine());
        Console.Write("Enter sequence exchange length (k): ");
        int seqLength = int.Parse(Console.ReadLine());

        if (firstSeq + seqLength > 32 || secondSeq + seqLength > 32 || firstSeq < 0 || secondSeq < 0)
        {
            Console.WriteLine("Out of range");
            return;
        }
        if (seqLength > Math.Abs(firstSeq - secondSeq))
        {
            Console.WriteLine("Overlapping");
            return;
        }

        for (int i = 0; i < seqLength; i++)
        {
            number = BitExchange(number, firstSeq + i, secondSeq + i);
        }

        Console.WriteLine("The new number is: " + number);
    }

    static long BitExchange(long number, int firstBit, int secondBit)
    {
        long mask = 0;
        long firstMask = (number & (1 << firstBit)) >> firstBit;
        long secondMask = (number & (1 << secondBit)) >> secondBit;

        if (firstMask == 0)
        {
            mask = (~(1 << secondBit));
            number = number & mask;
        }
        else
        {
            mask = 1 << secondBit;
            number = number | mask;
        }

        if (secondMask == 0)
        {
            mask = (~(1 << firstBit));
            number = number & mask;
        }
        else
        {
            mask = 1 << firstBit;
            number = number | mask;
        }

        firstBit++;
        secondBit++;
        return number;
    }
}

