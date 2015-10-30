using System;
using System.Globalization;
using System.Threading;

/*
Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

class PointInCircleOutOfRect
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        Console.Write("Enter X: ");
        decimal pointX = decimal.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        decimal pointY = decimal.Parse(Console.ReadLine());

        decimal circleRadius = 1.5M;
        decimal circleCenterX = 1.0M;
        decimal circleCenterY = 1.0M;

        bool isInsideCircle = (pointX - circleCenterX) * (pointX - circleCenterX) +
                            (pointY - circleCenterY) * (pointY - circleCenterY) <= circleRadius * circleRadius;

        bool isOutsideRect = (pointX < -1 || pointX > 5) || (pointY < -1 || pointY > 1);

        Console.Write("The point is inside the circle and outside the rectangle: ");
        if (isInsideCircle && isOutsideRect)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
