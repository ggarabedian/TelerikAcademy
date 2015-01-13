using System;

/*
Write an expression that extracts from given integer n the value of given bit at index p.
*/

class ExtractBitFromInt
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index: ");
        int bitIndex = int.Parse(Console.ReadLine());

        int bitValue = 0;
        int mask = 1;

        bitValue = number >> bitIndex & mask;

        Console.WriteLine("Bit value at position {0} is {1}", bitIndex, bitValue );
    }
}
