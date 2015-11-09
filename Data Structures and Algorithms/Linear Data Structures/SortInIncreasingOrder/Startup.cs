namespace SortInIncreasingOrder
{
    using System;
    using System.Linq;

    using LinearDataStructures.Utilities;

    /*
    03. Write a program that reads a sequence of integers (List<int>) ending with an empty line and 
    sorts them in an increasing order.
    */
    public class Startup
    {
        public static void Main()
        {
            var inputs = InputGenerator.GetInputAsList();

            Console.Write("The numbers in increasing order: ");
            foreach (var item in inputs.OrderBy(n => n))
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
