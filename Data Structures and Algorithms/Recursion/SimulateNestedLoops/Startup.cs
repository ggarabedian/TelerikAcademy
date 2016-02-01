namespace SimulateNestedLoops
{
    using System;

    /*
    01. Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.
    */
    public class Startup
    {
        public static void Main()
        {
            int n = 3;
            int[] arr = new int[n];

            GenerateCombinations(arr, 0, n);
        }

        private static void GenerateCombinations(int[] arr, int index, int endNum)
        {
            if (index >= arr.Length)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
            }
            else
            {
                for (int i = 1; i <= endNum; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(arr, index + 1, endNum);
                }
            }
        }
    }
}
