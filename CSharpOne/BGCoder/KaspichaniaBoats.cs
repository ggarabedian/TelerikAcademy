
using System;

public class Boats
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int boatHeight = 6 + ((N - 3) / 2) * 3;
        int boatWidth = N * 2 + 1;

        string firstRow = new string('.', N);
        Console.WriteLine("{0}*{0}", firstRow);

        for (int row = N - 1; row > 0; row--)
        {
            string dotsOutside = new string('.', row);
            string dotsInside = new string('.', N - row - 1);
            Console.WriteLine("{0}*{1}*{1}*{0}", dotsOutside, dotsInside);
        }

        Console.WriteLine(new string('*', boatWidth));

        for (int row = 1; row <= boatHeight / 3; row++)
        {
            string dotsOutside = new string('.', row);
            string dotsInside = new string('.', N - row - 1);
            string starCount = new string('*', N);

            if (row == (boatHeight / 3))
            {
                Console.WriteLine("{0}{1}{0}", dotsOutside, starCount);
            }
            else
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", dotsOutside, dotsInside);
            }
        }
    }
}
