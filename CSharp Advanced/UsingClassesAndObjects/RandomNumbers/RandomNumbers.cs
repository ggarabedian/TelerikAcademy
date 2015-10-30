using System;

/*
Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/

class LeapYear
{
    static void Main()
    {
        int minRange = 100;
        int maxRange = 200;

        GenerateRandomNumber(minRange, maxRange);
    }

    static void GenerateRandomNumber(int minRange, int maxRange)
    {
        int randomNumber = 0;
        Random rand = new Random();

        for (int i = 0; i < 10; i++)
        {
            randomNumber = rand.Next(minRange, maxRange + 1);
            Console.WriteLine(randomNumber);
        }
    }
}