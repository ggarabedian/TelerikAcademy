using System;

/*
Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, 
separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
*/

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int firstNumber = 0;
        int secondNumber = 1;
        int sum = 0;

        Console.Write("{0}, {1}, ", firstNumber, secondNumber);
        for (int i = 0; i <= number; i++)
        {
            sum = firstNumber + secondNumber;
            Console.Write("{0}, ", sum);
            firstNumber = secondNumber;
            secondNumber = sum;
        }

        Console.WriteLine();
    }
}
