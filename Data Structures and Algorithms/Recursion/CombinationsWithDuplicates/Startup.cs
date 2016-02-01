namespace CombinationsWithDuplicates
{
    using System;

    /*
    02. Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set. 
    Example: n=3, k=2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)
    */
    public class Startup
    {
        public static void Main()
        {
            int n = 3;
            int k = 2;
            var arr = new int[k];

            GenerateCombinations(arr, 0, 1, n);
        }

        private static void GenerateCombinations(int[] arr, int index, int start, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;

                if (index > 0 && arr[index] < arr[index - 1])
                {
                    continue;
                }

                GenerateCombinations(arr, index + 1, start, end);
            }
        }
    }
}
