namespace Assertions
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    public static class Searching
    {
        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array is null.");
            Debug.Assert(value != null, "Searched value is null.");
            Debug.Assert(startIndex >= 0 && startIndex < arr.Length, "Start index is out of range.");
            Debug.Assert(endIndex >= 0 && endIndex < arr.Length, "End index is out of range.");
            Debug.Assert(startIndex <= endIndex, "Start index is greater than end index.");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }
                if (arr[midIndex].CompareTo(value) < 0)
                {
                    startIndex = midIndex + 1;
                }
                else
                {
                    endIndex = midIndex - 1;
                }
            }

            bool containsValue = arr.Any(v => v.Equals(value));
            Debug.Assert(!containsValue, "The array contains the value, but returns -1");

            return -1;
        }
    }
}
