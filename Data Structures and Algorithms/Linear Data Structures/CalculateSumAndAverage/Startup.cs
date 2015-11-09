namespace CalculateSumAndAverage
{
    using System;
    using System.Linq;

    using LinearDataStructures.Utilities;

    /*
    01. Write a program that reads from the console a sequence of positive integer numbers.
        The sequence ends when empty line is entered.
        Calculate and print the sum and average of the elements of the sequence.
        Keep the sequence in List<int>.
    */
    public class Startup
    {
        public static void Main()
        {
            var inputs = InputGenerator.GetInputAsList();

            Console.WriteLine("Sum of the given numbers: {0}", inputs.Sum());
            Console.WriteLine("Average of the given numbers: {0:0.###}", inputs.Average());
        }
    }
}
