using System;

/*
Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
*/

class PerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        decimal radius = decimal.Parse(Console.ReadLine());

        decimal area = (decimal)Math.PI * radius * radius;
        decimal perimeter = 2 * radius * (decimal)Math.PI;

        Console.WriteLine("Perimeter: {0: 0.00}; Area: {1: 0.00}.", perimeter, area);
    }
}
