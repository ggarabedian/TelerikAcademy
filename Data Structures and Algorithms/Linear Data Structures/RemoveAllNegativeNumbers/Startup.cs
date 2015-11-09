namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using LinearDataStructures.Utilities;

    /*
    05. Write a program that removes from given sequence all negative numbers. Keep the sequence in List<int>.
    */
    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = InputGenerator.GetListOfRandomNumbers(-5, 6);

            Console.WriteLine("The original list of numbers: {0}", string.Join(", ", numbers));

            numbers = numbers.Where(n => n >= 0).ToList();

            Console.WriteLine("The resulting list of numbers: {0}", string.Join(", ", numbers));
        }
    }
}
