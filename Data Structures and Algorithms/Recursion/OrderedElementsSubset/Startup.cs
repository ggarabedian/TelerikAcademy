namespace OrderedElementsSubset
{
    using System;

    /*
    05. Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
    Example: n=3, k=2, set = {hi, a, b} → (hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
    */
    public class Startup
    {
        public static void Main()
        {
            int k = 2;
            var set = new string[] { "hi", "a", "b" };
            var arr = new string[k];

            GenerateOrderedSubsets(0, arr, set);
        }

        public static void GenerateOrderedSubsets(int index, string[] arr, string[] set)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    arr[index] = set[i];
                    GenerateOrderedSubsets(index + 1, arr, set);
                }
            }        
        }
    }
}
