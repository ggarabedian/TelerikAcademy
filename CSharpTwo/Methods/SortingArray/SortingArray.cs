using System;

/*
Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

class SortingArray
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int arraySize = int.Parse(Console.ReadLine());
        Console.Write("Enter starting index: ");
        int index = int.Parse(Console.ReadLine());

        int[] array = new int[arraySize];

        for (int i = 0; i < arraySize; i++)
        {
            Console.Write("Array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("The maximal element starting from index {0} is {1}", index, array[GetMaximalElement(array, index)]);
        Console.WriteLine("The array in descending order: " + string.Join(", ", DescendingOrder(array)));
        Console.WriteLine("The array in ascending order: " + string.Join(", ", AscendingOrder(array)));
    }

    static int GetMaximalElement(int[] array, int index)
    {
        int maxNumIndex = 0;

        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > array[maxNumIndex])
            {
                maxNumIndex = i;
            }
        }

        return maxNumIndex;
    }

    static int[] DescendingOrder(int[] array)
    {
        int[] copyArr = new int[array.Length];
        int[] resultArr = new int[array.Length];
        Array.Copy(array, copyArr, array.Length);

        for (int i = 0; i < array.Length; i++)
        {
            resultArr[i] = copyArr[GetMaximalElement(copyArr, 0)];
            copyArr[GetMaximalElement(copyArr, 0)] = 0;
        }

        return resultArr;
    }

    static int[] AscendingOrder(int[] array)
    {
        int[] copyArr = new int[array.Length];
        int[] resultArr = new int[array.Length];
        Array.Copy(array, copyArr, array.Length);

        for (int i = array.Length - 1; i >= 0; i--)
        {
            resultArr[i] = copyArr[GetMaximalElement(copyArr, 0)];
            copyArr[GetMaximalElement(copyArr, 0)] = 0;
        }

        return resultArr;
    }
}
