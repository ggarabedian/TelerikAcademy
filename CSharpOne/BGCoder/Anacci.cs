using System;

class Anacci
{
    static void Main()
    {
        char firstLetter = char.Parse(Console.ReadLine());
        char secondLetter = char.Parse(Console.ReadLine());
        int numberOfLines = int.Parse(Console.ReadLine());

        int emptySpaces = 1;

        int firstCode = (firstLetter - 'A') + 1;
        int secondCode = (secondLetter - 'A') + 1;
        int lastSum = (firstCode + secondCode);

        if (lastSum > 26)
        {
            lastSum = lastSum % 26;
        }

        if (numberOfLines == 1)
        {
            Console.WriteLine((char)(firstCode + 'A' - 1));
            return;
        }
        else if (numberOfLines == 2)
        {
            Console.WriteLine((char)(firstCode + 'A' - 1));
            Console.WriteLine((char)(secondCode + 'A' - 1) + "" + (char)(lastSum + 'A' - 1));
            return;
        }
        else
        {
            Console.WriteLine((char)(firstCode + 'A' - 1));
            Console.WriteLine((char)(secondCode + 'A' - 1) + "" + (char)(lastSum + 'A' - 1));
            for (int i = 0; i < (numberOfLines - 2)*2; i++)
            {
                firstCode = secondCode;
                secondCode = lastSum;
                lastSum = firstCode + secondCode;

                if (lastSum > 26)
                {
                    lastSum = lastSum % 26;
                }

                Console.Write((char)(lastSum + 'A' - 1));
                Console.Write(new string(' ', emptySpaces));

                if (i % 2 == 1)
                {
                    Console.WriteLine();
                    emptySpaces++;
                }
            }
        }
    }
}

