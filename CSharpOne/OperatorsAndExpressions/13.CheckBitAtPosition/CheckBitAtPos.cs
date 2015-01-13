using System;

/*
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
in given integer number n, has value of 1.
*/

class CheckBitAtPos
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index: ");
        int bitIndex = int.Parse(Console.ReadLine());

        int bitValue = 0;
        int mask = 1;
        bool isBitOne = false;

        bitValue = number >> bitIndex & mask;

        if (bitValue == 1)
        {
            isBitOne = true;
        }

        Console.WriteLine("Bit value at position {0} is 1: {1}", bitIndex, isBitOne);
    }
}