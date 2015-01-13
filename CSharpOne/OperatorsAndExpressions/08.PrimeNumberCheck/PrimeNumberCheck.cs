using System;

/*
Write an expression that checks if given positive integer number n (n = 100) is prime 
(i.e. it is divisible without remainder only to itself and 1).
*/

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int divider = 2;
        int maxDivider = (int)Math.Sqrt(number);
        bool isPrime = true;

        while (isPrime && (divider <= maxDivider))
        {
            if (number % divider == 0)
            {
                isPrime = false;
            }
            divider++;
        }

        Console.WriteLine(number + " is prime: " + isPrime);
    }
}

