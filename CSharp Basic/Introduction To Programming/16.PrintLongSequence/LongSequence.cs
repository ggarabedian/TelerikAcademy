﻿using System;

/*
Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
You might need to learn how to use loops in C# (search in Internet). 
*/

class LongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1002; i++)
        {
            if (i == 1002)
            {
                Console.WriteLine(i);
                break;
            }

            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write((i * (-1)) + ", ");
            }
        }
    }
}
