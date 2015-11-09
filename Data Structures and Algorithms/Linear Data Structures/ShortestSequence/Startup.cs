namespace ShortestSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*
    10. We are given numbers N and M and the following operations:  N = N+1;  N = N+2;  N = N*2
    Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
    Hint: use a queue.
    Example: N = 5, M = 16
    Sequence: 5 → 7 → 8 → 16
    */
    public class Startup
    {
        public static void Main()
        {
            int startingValue = 5;
            int valueToReach = 120;
            int currentValue = startingValue;

            var result = new Queue<int>();
            result.Enqueue(startingValue);

            while (result.Last() != valueToReach)
            {
                if (currentValue * 2 == valueToReach ||
                    currentValue * 2 == valueToReach - 1)
                {
                    result.Enqueue(currentValue *= 2);
                }

                if (currentValue * 2 <= valueToReach / 2 &&
                    currentValue * 2 <= valueToReach - 2)
                {
                    result.Enqueue(currentValue *= 2);
                    continue;
                }

                if (currentValue + 2 <= valueToReach &&
                    currentValue + 2 <= valueToReach / 2)
                {
                    result.Enqueue(currentValue += 2);
                    continue;
                }

                if (currentValue + 1 <= valueToReach)
                {
                    result.Enqueue(currentValue += 1);
                }
            }

            Console.WriteLine("N: {0}; M: {1}; Result: {2}", startingValue, valueToReach, string.Join(" -> ", result));
        }
    }
}
