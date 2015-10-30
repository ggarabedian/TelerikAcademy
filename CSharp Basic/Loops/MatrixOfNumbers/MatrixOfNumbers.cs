using System;

/*
Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix 
like in the examples below. Use two nested loops.
*/

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number between 1 and 20: ");
        int number = int.Parse(Console.ReadLine());

        int element = 1;

        for (int row = 0; row < number; row++)
        {
            for (int col = 0; col < number; col++)
            {
                Console.Write("{0} ", element + col);
            }
            element++;
            Console.WriteLine();
        }
    }
}

