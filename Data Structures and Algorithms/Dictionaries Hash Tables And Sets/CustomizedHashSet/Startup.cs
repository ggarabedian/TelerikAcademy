namespace CustomizedHashSet
{
    using System;

    /*
    Implement the data structure set in a class HashedSet<T> using your class HashTable<K,T> to hold the elements. 
    Implement all standard set operations like
    Add(T)
    Find(T)
    Remove(T)
    Count
    Clear()
    union and
    intersect
    Write unit tests for your class.
    */
    public class Startup
    {
        public static void Main()
        {
            var firstSet = new CustomHashSet<int>();

            for (int i = 1; i <= 20; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    firstSet.Add(i);
                }
            }

            Console.WriteLine("First hashset: {0} elements", firstSet.Count);
            Console.WriteLine(firstSet);

            var secondSet = new CustomHashSet<int>();
            
            for (int i = 10; i <= 30; i++)
            {
                secondSet.Add(i);
            }

            Console.WriteLine("Second hashset: {0} elements", secondSet.Count);
            Console.WriteLine(secondSet);

            Console.WriteLine("Intersection between the two hashsets: ");
            Console.WriteLine(firstSet.IntersectsWith(secondSet));

            Console.WriteLine("Union between the two hashsets: ");
            Console.WriteLine(firstSet.Union(secondSet));
        }
    }
}
