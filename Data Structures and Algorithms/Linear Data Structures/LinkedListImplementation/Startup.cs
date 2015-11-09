namespace LinkedListImplementation
{
    using System;

    /*
    11.Implement the data structure linked list.
    Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
    */
    public class Startup
    {
        public static void Main()
        {
            var linkedList = new CustomLinkedList<string>();

            linkedList.AddFirst("A very");
            linkedList.AddFirst("Special");
            linkedList.AddFirst("Space");
            linkedList.AddFirst("Monkey");
            Console.WriteLine("Result using add first: {0}", string.Join(" -> ", linkedList));
            Console.WriteLine("Linked list size: {0}", linkedList.Count);

            Console.WriteLine(new string('-', 50));

            linkedList.Clear();
            Console.WriteLine("Linked list size after clear: {0}", linkedList.Count);

            Console.WriteLine(new string('-', 50));

            linkedList.AddLast("A very");
            linkedList.AddLast("Special");
            linkedList.AddLast("Space");
            linkedList.AddLast("Monkey");
            Console.WriteLine("Result using add last: {0}", string.Join(" -> ", linkedList));

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("Does the list contains \"Space\"? => {0}", linkedList.Contains("Space"));
            Console.WriteLine("Does the list contains \"Mooonkey\"? => {0}", linkedList.Contains("Mooonkey"));

            Console.WriteLine(new string('-', 50));

            linkedList.RemoveFirst();
            Console.WriteLine("The list after removing the first element: {0}", string.Join(" -> ", linkedList));
        }
    }
}
