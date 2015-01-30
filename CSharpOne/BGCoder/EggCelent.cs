using System;

class EggCelent
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        int height = 2 * input;
        int width = 3 * input - 1;
        int drawAreaWidth = 3 * input + 1;

        int dotsCountMiddle = input + 1;
        int dotsCount = input + 1;

        Console.WriteLine("{0}{1}{0}", new string('.', dotsCount), new string('*', input - 1));

        dotsCount = input - 1;

        if (input > 2)
        {
		    for (int i = 0; i < input / 2; i++)
            {
                string dots = new string ('.', dotsCount);
                string middleDots = new string ('.', dotsCountMiddle);

                dotsCountMiddle = dotsCountMiddle + 4;
                dotsCount = dotsCount - 2;

                Console.WriteLine("{0}*{1}*{0}", dots, middleDots);
            }

            dotsCount = 1;
            dotsCountMiddle -= 4;

            for (int i = 0; i < input - 2 - input / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string ('.', dotsCount), new string ('.', dotsCountMiddle));
            }
        }


        Console.Write(".*");
        for (int j = 0; j < (width - 2) / 2; j++)
        {
            Console.Write("@");
            Console.Write(".");
        }
        Console.WriteLine("@*.");

        Console.Write(".*");
        for (int j = 0; j < (width - 2) / 2; j++)
        {
            Console.Write(".");
            Console.Write("@");
        }
        Console.WriteLine(".*.");

        if (input > 2)
        {
            for (int i = 0; i < input - 2 - input / 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotsCount), new string('.', dotsCountMiddle));
            }

            for (int i = 0; i < input / 2; i++)
            {
                string dots = new string('.', dotsCount);
                string middleDots = new string('.', dotsCountMiddle);

                dotsCountMiddle = dotsCountMiddle - 4;
                dotsCount = dotsCount + 2;

                Console.WriteLine("{0}*{1}*{0}", dots, middleDots);
            }
        }
        
        dotsCount = input + 1;

        Console.WriteLine("{0}{1}{0}", new string('.', dotsCount), new string('*', input - 1));
    }
}

