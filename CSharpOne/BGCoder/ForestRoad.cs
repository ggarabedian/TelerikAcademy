using System;

class ForestRoad
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int height = 2 * input - 1;

        int leftDots = 0;
        int rightDots = input - 1;

        int dotsMultipier = 1;

        for (int i = 0; i < height; i++)
        {
            string leftPath = new string('.', leftDots);
            string rightPath = new string('.', rightDots);

            if (rightDots == 0)
            {
                dotsMultipier *= -1;
            }

            leftDots = leftDots + dotsMultipier;
            rightDots = rightDots - dotsMultipier;

            Console.WriteLine("{0}*{1}", leftPath, rightPath);
        }
    }
}

