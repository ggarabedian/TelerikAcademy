namespace AllPermutations
{
    using System;
    using System.Linq;

    /*
    04. Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for 
    given integer number n. Example: n=3 → {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2},{3, 2, 1}
    */
    public class Startup
    {
        public static void Main()
        {
            var n = 3;
            var arr = new int[n];

            GeneratePermutations(1, n, arr, 0);
        }

        public static void GeneratePermutations(int startNumber, int endNumber, int[] arr, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
                return;
            }

            for (int number = startNumber; number <= endNumber; number++)
            {
                if (arr.Contains(number))
                {
                    continue;
                }

                arr[index] = number;
                GeneratePermutations(startNumber, endNumber, arr, index + 1);
                arr[index] = 0;
            }
        }
    }
}
