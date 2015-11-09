namespace NumberOccurrences
{
    using System;
    using System.Linq;

    using LinearDataStructures.Utilities;

    /*
    07. Write a program that finds in given array of integers (all belonging to the range [0..1000]) 
    how many times each of them occurs.
    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    2 → 2 times
    3 → 4 times
    4 → 3 times
    */
    public class Startup
    {
        public static void Main()
        {
            var numbers = InputGenerator.GetListOfRandomNumbers(0, 20).ToArray();

            Console.WriteLine("The original list of numbers: {0}", string.Join(", ", numbers));

            var groupedOccurrences = numbers.GroupBy(n => n);

            Console.WriteLine("Result: ");
            foreach (var occurrence in groupedOccurrences)
            {
                Console.WriteLine("{0} -> {1}", occurrence.Key, occurrence.Count());
            }
        }
    }
}
