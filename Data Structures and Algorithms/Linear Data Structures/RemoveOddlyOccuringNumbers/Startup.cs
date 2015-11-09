namespace RemoveOddlyOccuringNumbers
{
    using System;
    using System.Linq;

    using LinearDataStructures.Utilities;

    /*
    06. Write a program that removes from given sequence all numbers that occur odd number of times.
    Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
    */
    public class Startup
    {
        public static void Main()
        {
            var numbers = InputGenerator.GetListOfRandomNumbers(1, 10);

            var oddOccuringNumbers = numbers.GroupBy(n => n).Where(n => n.Count() % 2 == 1);

            Console.WriteLine("The original list of numbers: {0}", string.Join(", ", numbers));
            foreach (var number in oddOccuringNumbers)
            {
                numbers.RemoveAll(n => n == number.Key);
            }

            Console.WriteLine("The resulting list of numbers: {0}", string.Join(", ", numbers));
        }
    }
}
