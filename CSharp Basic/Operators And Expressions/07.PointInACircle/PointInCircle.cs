using System;
using System.Globalization;
using System.Threading;

/*
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2). 
*/

class PointInCircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.Write("Enter X: ");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        decimal pointY = decimal.Parse(Console.ReadLine());

        decimal circleRadius = 2.0M;
        decimal circleCenterX = 0.0M;
        decimal circleCenterY = 0.0M;

        bool isInsideCircle = (pointX - circleCenterX) * (pointX - circleCenterX) +
                            (pointY - circleCenterY) * (pointY - circleCenterY) <= circleRadius * circleRadius;

        Console.WriteLine("The point is inside the circle: " + isInsideCircle);
    }
}

