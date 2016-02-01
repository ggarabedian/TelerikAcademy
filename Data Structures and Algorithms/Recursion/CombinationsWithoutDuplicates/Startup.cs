namespace CombinationsWithoutDuplicates
{
    using System;

    /*
    03. Modify the previous program to skip duplicates:
    n=4, k=2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
    */
    public class Startup
    {
        public static void Main()
        {
            int n = 4;
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

                GenerateCombinations(arr, index + 1, i + 1, end);
            }
        }
    }
}
