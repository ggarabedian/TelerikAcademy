namespace ValueOccurrences
{
    using System;
    using System.Collections.Generic;

    /*
    01. Write a program that counts in a given array of double values the number of occurrences of each value. 
    Use Dictionary<TKey,TValue>.
    Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
    -2.5 -> 2 times
    3 -> 4 times
    4 -> 3 times
    */
    public class Startup
    {
        public static void Main()
        {
            var input = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            var dict = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentNumber = input[i];

                if (dict.ContainsKey(currentNumber))
                {
                    dict[currentNumber]++;
                }
                else
                {
                    dict[currentNumber] = 1;
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
