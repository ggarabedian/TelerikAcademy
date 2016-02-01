namespace AllSubsets
{
    using System;

    /*
    06. Write a program for generating and printing all subsets of k strings from given set of strings.
    Example: s = {test, rock, fun}, k=2 → (test rock), (test fun), (rock fun)
    */
    public class Startup
    {
        public static void Main()
        {
            int k = 2;
            var set = new string[] { "test", "rock", "fun" };
            var arr = new string[k];

            GenerateOrderedSubsets(0, 0, arr, set);
        }

        public static void GenerateOrderedSubsets(int index, int setIndex, string[] arr, string[] set)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("({0})", string.Join(", ", arr));
            }
            else
            {
                for (int i = setIndex; i < set.Length; i++)
                {
                    arr[index] = set[i];
                    GenerateOrderedSubsets(index + 1, i + 1, arr, set);
                }
            }
        }
    }
}
