namespace FindMajorant
{
    using System;
    using System.Linq;

    using LinearDataStructures.Utilities;

    /*
    08. The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
    Write a program to find the majorant of given array (if exists).
    Example: {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
    */
    public class Startup
    {
        public static void Main()
        {
            var numbers = InputGenerator.GetListOfRandomNumbers(1, 4);
            bool majorantExist = false;
            int majorantValue = 0;

            Console.WriteLine("The original list of numbers: {0}", string.Join(", ", numbers));

            var groupedOccurrences = numbers.GroupBy(n => n);

            foreach (var occurrence in groupedOccurrences)
            {
                if (occurrence.Count() >= (numbers.Count / 2) + 1)
                {
                    majorantExist = true;
                    majorantValue = occurrence.Key;
                }           
            }

            if (majorantExist)
            {
                Console.WriteLine("Majorant found! It's the number: {0}", majorantValue);
            }
            else
            {
                Console.WriteLine("Current list of numbers does not contain a majorant!");
            }            
        }
    }
}
