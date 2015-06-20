/*
Implement a set of extension methods for IEnumerable<T> that implement the following group 
functions: sum, product, min, max, average.
*/

namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        static void Main()
        {
            List<int> someList = new List<int>();

            someList.Add(5);
            someList.Add(15);
            someList.Add(7);
            someList.Add(13);
            someList.Add(15);
            someList.Add(25);

            Console.WriteLine(String.Join(", ", someList));

            Console.WriteLine("Sum: " + someList.Sum());
            Console.WriteLine("Product: " + someList.Product());
            Console.WriteLine("Min: " + someList.Min());
            Console.WriteLine("Max: " + someList.Max());
            Console.WriteLine("Average: " + someList.Average());
        }
    }
}
