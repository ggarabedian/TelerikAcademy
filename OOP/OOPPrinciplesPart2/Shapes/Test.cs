namespace Shapes
{
    using System;
    using System.Collections.Generic;
    
    using Models;

    public class Test
    {
        static void Main()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(5.0, 10.0),
                new Rectangle(3.5, 5.8),
                new Rectangle(7.0, 12.0),
                new Triangle(2.0, 3.6),
                new Triangle(7.0, 13.6),
                new Triangle(7.5, 3.8),
                new Square(7.5),
                new Square(3.9),
                new Square(2.6),
            };

            foreach (var shape in shapes)
            {
                Console.Write(shape.ToString());
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
