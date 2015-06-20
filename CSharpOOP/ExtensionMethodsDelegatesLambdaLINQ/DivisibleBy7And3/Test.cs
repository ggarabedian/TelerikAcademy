/*
Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ. 
*/

namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    class Test
    {
        static void Main()
        {
            int[] arrayOfNumbers = new int[] { 17, 21, 42, 63, 16, 22, 34, 72, 123, 3, 85, 105 };

            var specialNumbers = arrayOfNumbers.Where(n => n % 21 == 0).ToArray();
            //var specialNumbers = from n in arrayOfNumbers
            //                     where n % 21 == 0
            //                     select n;

            Console.WriteLine("Original array of numbers: " + string.Join(", ", arrayOfNumbers));
            Console.WriteLine("Numbers divisible by 3 and 7 at the same time: " + string.Join(", ", specialNumbers));
        }
    }
}
