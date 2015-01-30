using System;

class Fire
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int cols = number;
        int rowsUpperSide = number * 3 / 4;
        int rowsBottomSide = number / 2;

        int dotsUpperSide = number / 2 - 1;
        int dotsMiddle = 0;

        for (int row = 0; row < number / 2; row++)
        {
            string outerDots = new string('.', dotsUpperSide - row);
            string innerDots = new string('.', dotsMiddle);
            Console.Write("{0}#{1}#{0}", outerDots, innerDots, outerDots);
            dotsMiddle += 2;
            Console.WriteLine();
        }

        dotsMiddle = number - 2;

        for (int row = 0; row < number / 4; row++)
        {
            string outerDots = new string('.', row);
            string innerDots = new string('.', dotsMiddle);
            Console.Write("{0}#{1}#{0}", outerDots, innerDots, outerDots);
            dotsMiddle -= 2;
            Console.WriteLine();
        }

        Console.WriteLine(new string('-', number));

        for (int row = 0; row < rowsBottomSide; row++)
        {
            int slashCount = number / 2;
            string outerDots = new string('.', row);
            string slashLeft = new string('\\', slashCount - row);
            string slashRight = new string('/', slashCount - row);

            Console.WriteLine("{0}{1}{2}{0}", outerDots, slashLeft, slashRight, outerDots);
        }
    }
}

