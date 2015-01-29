using System;

class ExcelColumns
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        long result = 0;
        int powerOf = input - 1;

        for (int i = 0; i < input; i++)
        {
            char curChar = char.Parse(Console.ReadLine());

            result = result + ((curChar - 'A' + 1) * (long)Math.Pow(26, powerOf));

            powerOf--;
        }

        Console.WriteLine(result);
    }
}

