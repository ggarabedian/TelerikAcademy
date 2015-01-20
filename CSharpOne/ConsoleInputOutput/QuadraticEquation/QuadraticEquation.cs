using System;

/*
Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
*/

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter coefficient a: ");
        double coefA = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double coefB = double.Parse(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double coefC = double.Parse(Console.ReadLine());

        QuadraticEquationSolver(coefA, coefB, coefC);
    }

    public static void QuadraticEquationSolver(double a, double b, double c)
    {
        double sqrtpart = b * b - 4 * a * c;
        double x, x1, x2;
        if (sqrtpart > 0)
        {
            x1 = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            x2 = (-b - Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("Two Real Roots: {0} or  {1}", x1, x2);
        }
        else if (sqrtpart < 0)
        {
            Console.WriteLine("No Real Roots");
        }
        else
        {
            x = (-b + Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("One Real Root: {0}", x);
        }
    }
}

