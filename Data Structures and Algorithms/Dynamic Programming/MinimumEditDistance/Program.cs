namespace MinimumEditDistance
{
    using System;

    class Program
    {
        const decimal COST_DELETE = 0.9m;
        const decimal COST_INSERT = 0.8m;
        const decimal COST_REPLACE = 1.0m;

        static void Main()
        {
            decimal test = EditDistanceDynamic("developer", "enveloped");
            Console.WriteLine("Transformation cost: " + test);

            decimal test2 = EditDistanceDynamic("Thou shalt not", "You should not");
            Console.WriteLine("Transformation cost: " + test2);
        }

        static decimal EditDistanceDynamic(string pattern, string input)
        {
            decimal[,] table = new decimal[2, input.Length + 1];

            for (int pi = 1; pi <= input.Length; ++pi)
            {
                table[0, pi] = pi * COST_DELETE;
            }

            int pp;
            for (pp = 1; pp <= pattern.Length; ++pp)
            {
                int thisRow = pp % 2;
                int prevRow = 1 - thisRow;

                table[thisRow, 0] = pp * COST_INSERT;

                for (int pi = 1; pi <= input.Length; ++pi)
                {
                    decimal cost = (input[pi - 1] == pattern[pp - 1]) ? 0 : COST_REPLACE;

                    decimal minCostPi = table[thisRow, pi - 1] + COST_DELETE;
                    decimal minCost2 = table[prevRow, pi - 1] + cost;
                    decimal minCostPp = table[prevRow, pi] + COST_INSERT;

                    table[thisRow, pi] = Math.Min(Math.Min(minCostPp, minCostPi), minCost2);
                }

            }

            return table[1 - (pp % 2), input.Length];
        }
    }
}
