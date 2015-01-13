using System;

/*
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
*/

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool canBeDivided = false;

        if (number % 35 == 0)
        {
            canBeDivided = true;
        }

        Console.WriteLine("The number can be divided by 7 and 5: {0}", canBeDivided);
    }
}

