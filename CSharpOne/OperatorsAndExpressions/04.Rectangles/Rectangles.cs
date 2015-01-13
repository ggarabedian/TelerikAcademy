using System;
using System.Globalization;
using System.Threading;

/*
Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.Write("Enter width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        decimal height = decimal.Parse(Console.ReadLine());

        decimal perimeter = 2 * width + 2 * height;
        decimal area = width * height;

        Console.WriteLine("The perimeter of the rectangle is: {0}", perimeter);
        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}
