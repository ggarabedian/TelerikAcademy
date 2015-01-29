using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int result = 0;

        if (x == 0 && y == 0)
        {
            result = 0;
        }
        else if (x == 0 && (y > 0 || y < 0))
        {
            result = 5;
        }
        else if (y == 0 && (x > 0 || x < 0))
        {
            result = 6;
        }
        else if (x > 0 && y > 0)
        {
            result = 1;
        }
        else if (x > 0 && y < 0)
        {
            result = 4;
        }
        else if (x < 0 && y < 0)
        {
            result = 3;
        }
        else
        {
            result = 2;
        }

        Console.WriteLine(result);
    }
}

