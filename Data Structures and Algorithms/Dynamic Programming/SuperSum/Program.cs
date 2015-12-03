using System;

namespace SuperSum
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            Console.WriteLine(SuperSum(k, n));
        }

        static int SuperSum(int K, int N)
        {
            int result = 0;

            if (K == 0)
            {
                return N;
            }

            for (int i = 1; i <= N; i++)
            {
                result += SuperSum(K - 1, i);
            }

            return result;
        }
    }
}
