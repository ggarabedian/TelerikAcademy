using System;

/*
Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());

        int firstBit = 3;
        int secondBit = 24;
        long mask = 0;

        for (int i = 0; i < 3; i++)
        {
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
        }

        Console.WriteLine("The new number is: " + number);
    }
}