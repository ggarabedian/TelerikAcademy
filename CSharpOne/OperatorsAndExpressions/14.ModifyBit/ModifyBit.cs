using System;

/*
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v 
at the position p from the binary representation of n while preserving all other bits in n.
*/

class ModifyBit
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter bit index: ");
        int bitIndex = int.Parse(Console.ReadLine());
        Console.Write("Enter bit value(0, 1): ");
        int bitValue = int.Parse(Console.ReadLine());

        int mask = 0;
        int result = 0;

        if (bitValue == 1)
        {
            mask = 1 << bitIndex;
            result = number | mask;
        }
        else
        {
            mask = ~(1 << bitIndex);
            result = number & mask;
        }

        Console.WriteLine("The new number is: " + result);
    }
}
