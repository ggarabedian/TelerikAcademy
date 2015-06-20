using System;
using System.Collections.Generic;

/*
Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/

class PrimeNumbers
{
    static void Main()
    {
        int primeNumberRange = 10000000;
        List<int> primeList = new List<int>();

        primeList = GetPrimeNumbers(primeNumberRange);

        Console.WriteLine(string.Join(", ", primeList));
        Console.WriteLine("Between 1 and 10 000 000 there are {0} prime numbers!", primeList.Count);

    }

    static List<int> GetPrimeNumbers(int maxRange)
    {
        List<int> primes = new List<int>() { 2 };
        double maxSquareRoot = Math.Sqrt(maxRange);
        bool[] eliminated = new bool[maxRange + 1];

        for (int i = 3; i < maxRange; i+=2)
        {
            if (!eliminated[i])
            {
                primes.Add(i);
                
                if (i < maxSquareRoot)
                {
                    for (int j = i * i; j < maxRange; j+= 2 * i)
                    {
                        eliminated[j] = true;
                    }
                }
            }
        }
        return primes;
    }
}
