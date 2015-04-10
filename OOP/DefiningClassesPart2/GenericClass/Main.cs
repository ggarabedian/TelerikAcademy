namespace DefiningClassesPart2Main.GenericClass
{
    using System;

    public class GenericListMain
    {
        static void Main()
        {
            GenericList<int> genericList = new GenericList<int>();

            genericList.AddElement(25);
            genericList.AddElement(12);
            genericList.AddElement(32);
            genericList.AddElement(42);
            genericList.AddElement(60);

            genericList.RemoveElement(2);

            genericList.InsertElement(55, 3);

            Console.WriteLine(genericList.ToString());

            int indexToLookAt = 3;
            Console.WriteLine("Element at index {0} is {1}", indexToLookAt, genericList.ElementAtIndex(indexToLookAt));

            int elementToBeFound = 42;
            Console.WriteLine("Element {0} is at index {1}", elementToBeFound, genericList.FindElementByValue(elementToBeFound));

            Console.WriteLine("The min element: {0}", genericList.Min());
            Console.WriteLine("The max element: {0}", genericList.Max());

            genericList.Clear();

            Console.WriteLine(genericList.ToString());
        }
    }
}
