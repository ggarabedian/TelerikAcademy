namespace Stack
{
    using System;

    /*
    12.Implement the ADT stack as auto-resizable array.
    Resize the capacity on demand (when no space is available to add / insert a new element).
    */
    public class Startup
    {
        public static void Main()
        {
            var customStack = new CustomStack<int>();

            Console.WriteLine("Custom stack initial size: {0}", customStack.Items.Length);
            Console.WriteLine("Custom stack items count: {0}", customStack.Count);

            customStack.Push(5);
            customStack.Push(15);
            customStack.Push(25);
            customStack.Push(35);
            customStack.Push(45);

            Console.WriteLine("Custom stack after 5 insertions: {0}", customStack.Items.Length);
            Console.WriteLine("Custom stack items count: {0}", customStack.Count);
        }
    }
}
