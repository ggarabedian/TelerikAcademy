using System;

/*
Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
*/

class TriangleSurface
{
    static void Main()
    {
        Console.Write("Enter first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("Enter second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("Enter third side: ");
        double thirdSide = double.Parse(Console.ReadLine());
        Console.Write("Enter altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        Console.Write("Enter angle: ");
        double angle = double.Parse(Console.ReadLine());
        angle = Math.PI * angle / 180.0;

        double result;

        result = CalculateTriangleSurface.UsingSideAndAltitude(firstSide, altitude);
        Console.WriteLine("Triangle area using side and altitude: " + result);
        result = CalculateTriangleSurface.UsingThreeSides(firstSide, secondSide, thirdSide);
        Console.WriteLine("Triangle area using three sides: " + result);
        result = CalculateTriangleSurface.UsingTwoSidesAndAngle(firstSide, secondSide, angle);
        Console.WriteLine("Triangle area using two sides and angle: " + result);

    }
}
