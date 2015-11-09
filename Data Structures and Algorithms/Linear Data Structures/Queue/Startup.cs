namespace Queue
{
    using System;

    /*
    13.Implement the ADT queue as dynamic linked list.
    Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
    */
    public class Startup
    {
        public static void Main()
        {
            var customQueue = new CustomQueue<int>();

            customQueue.Enqueue(10);
            customQueue.Enqueue(20);
            customQueue.Enqueue(30);
            customQueue.Enqueue(40);
            customQueue.Enqueue(50);

            Console.Write("Testing enqueue... Queue elements count: {0}. Elements are: ", customQueue.Count);
            foreach (var item in customQueue)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();

            customQueue.Dequeue();
            customQueue.Dequeue();

            Console.Write("Testing dequeue... Queue elements count: {0}. Elements are: ", customQueue.Count);
            foreach (var item in customQueue)
            {
                Console.Write("{0} ", item);
            }

            Console.WriteLine();
        }
    }
}
