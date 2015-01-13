using System;

/*
Write an expression that checks for given integer if its third digit from right-to-left is 7.
*/

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool thirdDigitSeven = false;

        number /= 100;

        if (number % 10 == 7)
        {
            thirdDigitSeven = true;
        }

        Console.WriteLine("Third digit(from right to left) is seven: {0}", thirdDigitSeven);
    }
}

