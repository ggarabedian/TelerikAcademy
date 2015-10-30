namespace QualityMethods
{
    using System;

    public class EntryPoint
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            // Print numbers different ways
            Methods.PrintNumberWithPrecision(1.3);
            Methods.PrintNumberAsPecentage(0.75);
            Methods.PrintNumberRightAligned(2.30);

            // Points and Lines
            double x1 = 3;
            double x2 = -1;
            double y1 = 3;
            double y2 = 2.5;

            Console.WriteLine(Methods.CalculateDistance(x1, x2, y1, y2));

            bool horizontal = Methods.IsLineHorizontal(y1, y2);
            Console.WriteLine("Horizontal? " + horizontal);

            bool vertical = Methods.IsLineVertical(x1, x2);
            Console.WriteLine("Vertical? " + vertical);

            // Students and Age Comparison
            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");

            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, likes gaming and have high grades");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
