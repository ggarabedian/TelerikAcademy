namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    using LinearDataStructures.Utilities;

    /*
    04. Write a method that finds the longest subsequence of equal numbers in given List and returns the 
    result as new List<int>.
    Write a program to test whether the method works correctly.
    */
    public class Startup
    {
        public static void Main()
        {
            List<int> numbers = InputGenerator.GetListOfRandomNumbers(1, 10);
            List<int> result = GetLongestSubsequanceOfEqualNumbers(numbers);

            Console.WriteLine("The list of numbers: {0}", string.Join(", ", numbers));
            Console.WriteLine("The longest subsequence of equal numbers: {0}", string.Join(", ", result));
        }

        private static List<int> GetLongestSubsequanceOfEqualNumbers(List<int> numbers)
        {
            var bestCount = 1;
            var currentCount = 1;
            var bestNumber = numbers[0];
            var bestSubsequence = new List<int>();

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount >= bestCount)
                {
                    bestCount = currentCount;
                    bestNumber = numbers[i];
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                bestSubsequence.Add(bestNumber);
            }

            return bestSubsequence;
        }
    }
}
