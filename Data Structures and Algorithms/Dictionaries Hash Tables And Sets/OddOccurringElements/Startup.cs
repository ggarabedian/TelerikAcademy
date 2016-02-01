namespace OddOccurringElements
{
    using System;
    using System.Linq;

    /*
    02. Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.
    Example: {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
    */
    public class Startup
    {
        public static void Main()
        {
            string sequence = "C#, SQL, PHP, PHP, SQL, SQL";

            var result = sequence
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .GroupBy(i => i);

            foreach (var item in result)
            {
                if (item.Count() % 2 == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
