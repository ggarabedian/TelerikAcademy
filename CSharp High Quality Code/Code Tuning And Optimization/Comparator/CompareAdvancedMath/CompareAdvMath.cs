namespace CompareAdvancedMath
{
    using System;
    using System.Diagnostics;

    public class CompareAdvMath
    {
        public static void Main()
        {
            PerformanceComparator.ComparePerformance(MathFunctions.Sqrt);
            PerformanceComparator.ComparePerformance(MathFunctions.Log);
            PerformanceComparator.ComparePerformance(MathFunctions.Sin);
        }    
    }
}
