using System;

/*
Write an expression that checks if given integer is odd or even.
*/

class OddOrEven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = false;

        if (number % 2 == 1)
        {
            isOdd = true;
        }

        Console.WriteLine("The number is odd: {0}", isOdd);
    }
}
