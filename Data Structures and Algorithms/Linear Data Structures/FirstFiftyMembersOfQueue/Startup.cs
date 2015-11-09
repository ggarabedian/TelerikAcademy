﻿namespace FirstFiftyMembersOfQueue
{
    using System;
    using System.Collections.Generic;

    /*
    09. We are given the following sequence:
    S1 = N;  S2 = S1 + 1;  S3 = 2*S1 + 1;  S4 = S1 + 2;  S5 = S2 + 1;  S6 = 2*S2 + 1;  S7 = S2 + 2;
    Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
    */
    public class Startup
    {
        public static void Main()
        {
            int startingValue = 2;
            int membersCount = 50;
            var sequence = new Queue<int>();

            sequence.Enqueue(startingValue);

            Console.Write("N={0} -> ", startingValue);
            for (int i = 0; i < membersCount / 3; i++)
            {
                int currentNumber = sequence.Peek();

                sequence.Enqueue(currentNumber + 1);
                sequence.Enqueue((2 * currentNumber) + 1);
                sequence.Enqueue(currentNumber + 2);

                Console.Write(sequence.Dequeue() + ", ");
            }

            Console.Write(string.Join(", ", sequence));
        }
    }
}
