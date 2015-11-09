namespace ReverseNumbersUsingStack
{
    using System;
    using System.Collections.Generic;

    using LinearDataStructures.Utilities;

    /*
    02. Write a program that reads N integers from the console and reverses them using a stack.
        Use the Stack<int> class.
    */
    public class Startup
    {
        public static void Main()
        {
            Stack<int> inputs = InputGenerator.GetInputAsStack();

            Console.Write("The numbers reversed: ");
            while (inputs.Count > 0)
            {
                Console.Write(inputs.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}
