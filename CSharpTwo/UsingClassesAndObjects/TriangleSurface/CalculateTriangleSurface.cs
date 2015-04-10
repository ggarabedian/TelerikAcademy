using System;

class CalculateTriangleSurface
{
    public static double UsingSideAndAltitude(double side, double altitude)
    {
        double result = 0.5d * side * altitude;        
        return result;
    }

    public static double UsingThreeSides(double side1, double side2, double side3)
    {
        double semiParameter = (side1 + side2 + side3) / 2;
        double squareRoot = (semiParameter * (semiParameter - side1) * (semiParameter - side2) * (semiParameter - side3));
        double result = Math.Sqrt(squareRoot);
        return result;
    }

    public static double UsingTwoSidesAndAngle(double side1, double side2, double angle)
    {
        double result = ((side1 * side2) * 0.5d) * Math.Sin(angle);

        return result;
    }

}

