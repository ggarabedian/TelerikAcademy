using System;

/*
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

class ExtractBitThree
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int bitValue = 0;
        int mask = 1;

        bitValue = number >> 3 & mask;

        Console.WriteLine("Bit value: " + bitValue);
    }
}

