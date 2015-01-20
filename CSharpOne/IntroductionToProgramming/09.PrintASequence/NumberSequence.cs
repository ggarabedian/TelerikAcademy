using System;

/*
Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

class NumberSequence
{
    static void Main()
    {
        int firstNumber = 2;
        int secondNumber = -3;

        for (int i = 0; i < 5; i++)
        {
            if (i == 4)
            {
                Console.WriteLine("{0}, {1}.", firstNumber, secondNumber);
            }
            else
            {
                Console.Write("{0}, {1}, ", firstNumber, secondNumber);
            }

            firstNumber += 2;
            secondNumber -= 2;
        }
        Console.WriteLine();
    }
}