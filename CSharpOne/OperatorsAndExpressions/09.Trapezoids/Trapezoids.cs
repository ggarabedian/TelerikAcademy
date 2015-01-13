using System;
using System.Globalization;
using System.Threading;

/*
Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

class Trapezoids
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.Write("Enter first side: ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        decimal b = decimal.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        decimal h = decimal.Parse(Console.ReadLine());

        decimal area = 0;

        area = ((a + b) / 2) * h;

        Console.WriteLine("The area is: " + area);
    }
}

