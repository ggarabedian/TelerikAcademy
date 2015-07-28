namespace Assertions
{
    using System;
    using System.Linq;
    using System.Diagnostics;

    public static class Sorting
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }

            Debug.Assert(IsSorted(arr), "The array is sorted INCORRECTLY");
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            Debug.Assert(IsMinElement(arr, minElementIndex), "Incorrect min element selected");

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static bool IsSorted<T>(T[] arr)
            where T : IComparable<T>
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i-1]) < 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsMinElement<T>(T[] arr, int elementIndex)
            where T : IComparable<T>
        {
            return (arr.Min().CompareTo(arr[elementIndex]) <= 0);          
        }
    }
}
