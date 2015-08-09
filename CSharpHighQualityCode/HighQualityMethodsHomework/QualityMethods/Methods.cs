namespace QualityMethods
{
    using System;

    public class Methods
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double sum = (a + b + c) / 2;
            double area = Math.Sqrt(sum * (sum - a) * (sum - b) * (sum - c));
            return area;
        }

        internal static string NumberToDigit(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "Input is not a digit!";
            }
        }

        internal static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Given array cannot be null or empty");
            }

            int currentMaxElement = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > currentMaxElement)
                {
                    currentMaxElement = elements[i];
                }
            }

            return currentMaxElement;
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintNumberAsPecentage(double number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        internal static void PrintNumberRightAligned(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        internal static double CalculateDistance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        internal static bool IsLineHorizontal(double y1, double y2)
        {
            bool isHorizontal = y1 == y2;
            return isHorizontal;
        }

        internal static bool IsLineVertical(double x1, double x2)
        {
            bool isVertical = x1 == x2;
            return isVertical;
        }
    }
}