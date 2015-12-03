using System;

namespace Tribonnacci
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            long t1 = long.Parse(input[0]);
            long t2 = long.Parse(input[1]);
            long t3 = long.Parse(input[2]);
            int n = int.Parse(input[3]);

            if (n == 1)
            {
                Console.WriteLine(t1);
            }
            else if (n == 2)
            {
                Console.WriteLine(t2);
            }
            else if (n == 3)
            {
                Console.WriteLine(t3);
            }
            else
            {
                for (int i = 4; i <= n; i++)
                {
                    long tribNum = t1 + t2 + t3;
                    t1 = t2;
                    t2 = t3;
                    t3 = tribNum;
                }

                Console.WriteLine(t3);
            }
        }
    }
}
