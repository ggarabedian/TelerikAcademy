using System;
using System.Globalization;
using System.Threading;

/*
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

class MoonGravitation
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.Write("Enter weight: ");
        decimal number = decimal.Parse(Console.ReadLine());

        decimal weightOnMoon = number * 17 / 100;

        Console.WriteLine("Weight on the moon is: {0}", weightOnMoon);
    }
}
