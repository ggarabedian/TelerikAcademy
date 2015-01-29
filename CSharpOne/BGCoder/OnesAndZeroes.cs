using System;

class OnesAndZeroes
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());

        char[] charArray;

        string number = Convert.ToString(input, 2);
        number = number.PadLeft(16, '0');

        charArray = number.ToCharArray();


        if (charArray.Length > 16)
        {
            number = number.Remove(0, charArray.Length - 16);
        }

        charArray = number.ToCharArray();

        DrawTopRow(charArray);
        DrawMiddleSpecialRow(charArray);
        DrawMiddleRow(charArray);
        DrawMiddleRow(charArray);
        DrawBottomRow(charArray);

    }

    static void DrawTopRow(char[] someArray)
    {
        for (int i = 0; i < 16; i++)
        {
            if (someArray[i] == '0')
            {
                Console.Write("###");
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            else
            {
                Console.Write(".#.");
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
        }
        Console.WriteLine();
    }

    static void DrawMiddleSpecialRow(char[] someArray)
    {
        for (int i = 0; i < 16; i++)
        {
            if (someArray[i] == '0')
            {
                Console.Write("#.#");
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            else
            {
                Console.Write("##.");
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
        }
        Console.WriteLine();
    }

    static void DrawMiddleRow(char[] someArray)
    {
        for (int i = 0; i < 16; i++)
        {
            if (someArray[i] == '0')
            {
                Console.Write("#.#");
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
            else
            {
                Console.Write(".#.");
                if (i < 15)
                {
                    Console.Write(".");
                }
            }
        }
        Console.WriteLine();
    }

    static void DrawBottomRow(char[] someArray)
    {
        for (int i = 0; i < 16; i++)
        {
            Console.Write("###");
            if (i < 15)
            {
                Console.Write(".");
            }         
        }
        Console.WriteLine();
    }
}

