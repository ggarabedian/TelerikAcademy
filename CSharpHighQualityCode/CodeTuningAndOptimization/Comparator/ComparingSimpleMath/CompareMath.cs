namespace ComparingSimpleMath
{
    public class CompareMath
    {
        public static void Main()
        {
            PerformanceComparator.ComparePerformance(Operations.Addition);
            PerformanceComparator.ComparePerformance(Operations.Subtraction);
            PerformanceComparator.ComparePerformance(Operations.Multiplication);
            PerformanceComparator.ComparePerformance(Operations.Division);
        }
    }
}
