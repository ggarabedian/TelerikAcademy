using System;

/*
Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
   ©

  © ©

 ©   ©

© © © ©
*/

class IsoscelesTriangle
{
    static void Main()
    {
        
        char symbol = '\u00a9';

        for (int i = 0; i < 4; i++)
        {
            for (int j = 3 - i; j > 0; j--)
            {
                Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                if (i == 2 && j == 1)
                {
                    Console.Write("  ");
                }
                else
                {
                    Console.Write(symbol + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

