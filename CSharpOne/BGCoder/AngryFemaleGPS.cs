using System;

class AngryFemaleGPS
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());

        if (N < 0)
        {
            N = -N;
        }

        long sumEvenDigit = 0;
        long sumOddDigit = 0;

        while (N != 0)
        {
            long curElement = N % 10;

            if (curElement % 2 == 0)
            {
                sumEvenDigit += curElement;
            }
            else if (curElement % 2 == 1)
            {
                sumOddDigit += curElement;
            }

            N /= 10;
        }

        if (sumEvenDigit > sumOddDigit)
        {
            Console.WriteLine("right " + sumEvenDigit);
        }
        else if (sumOddDigit > sumEvenDigit)
        {
            Console.WriteLine("left " + sumOddDigit);
        }
        else
        {
            Console.WriteLine("straight " + sumEvenDigit);
        }
    }
}
