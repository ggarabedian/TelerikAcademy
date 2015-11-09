namespace PriorityQueueImplementation
{
    using System;

    public class Startup
    {
        public static void Main()
        {

            PriorityQueue<int> maxPriorityQueue = new PriorityQueue<int>(5);
            maxPriorityQueue.Insert(9);
            maxPriorityQueue.Insert(1);
            maxPriorityQueue.Insert(5);
            maxPriorityQueue.Insert(7);
            maxPriorityQueue.Insert(3);
            maxPriorityQueue.Insert(2);

            Console.WriteLine("Max Priority Queue: ");
            while (maxPriorityQueue.Size > 0)
            {
                Console.Write(maxPriorityQueue.Pop() + " ");
            }

            Console.WriteLine();

            PriorityQueue<int> minPriorityQueue = new PriorityQueue<int>(5, Comparator);

            minPriorityQueue.Insert(9);
            minPriorityQueue.Insert(1);
            minPriorityQueue.Insert(5);
            minPriorityQueue.Insert(7);
            minPriorityQueue.Insert(3);
            minPriorityQueue.Insert(2);

            Console.WriteLine("Min Priority Queue: ");
            while (minPriorityQueue.Size > 0)
            {
                Console.Write(minPriorityQueue.Pop() + " ");
            }

            Console.WriteLine();
        }

        private static int Comparator(int i1, int i2)
        {
            return i1 < i2 ? 1 : i1 > i2 ? -1 : 0;
        }
    }
}
