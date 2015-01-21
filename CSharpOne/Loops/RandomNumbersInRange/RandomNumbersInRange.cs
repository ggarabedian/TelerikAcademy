using System;

/*
Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
*/

class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter amount of numbers to be printed: ");
        int amount = int.Parse(Console.ReadLine());
        Console.Write("Enter min value: ");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Enter max value: ");
        int maxValue = int.Parse(Console.ReadLine());

        Random random = new Random();

        for (int i = 0; i < amount; i++)
        {
            int randomNumber = random.Next(minValue, maxValue + 1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}

