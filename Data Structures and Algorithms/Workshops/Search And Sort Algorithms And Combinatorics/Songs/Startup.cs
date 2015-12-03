namespace Songs
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int inversions = 0;

            var array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var rename = new int[n + 1];

            for (int i = 0; i < n; i++)
            {
                rename[array1[i]] = i;
            }

            for (int i = 0; i < n; i++)
            {
                array2[i] = rename[array2[i]];
            }

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array2[i] > array2[j])
            //        {
            //            inversions++;
            //        }
            //    }
            //}

            Console.WriteLine(CounteInversions(array2, 0, n));
        }

        public static long CounteInversions(int[] arr, int left, int right)
        {
            if (left + 1 == right)
            {
                return 0;
            }

            int middle = (left + right) / 2;

            long inversions = CounteInversions(arr, left, middle) + CounteInversions(arr, middle, right);

            int[] sorted = new int[right - left];
            int i = left;
            int j = middle;
            int k = 0;

            while (i < middle && j < right)
            {
                if (arr[i] < arr[j])
                {
                    sorted[k] = arr[i];
                    i++;
                }
                else
                {
                    inversions += middle - i;
                    sorted[k] = arr[j];
                    j++;
                }

                k++;
            }

            while (i < middle)
            {
                sorted[k] = arr[i];
                i++;
                k++;
            }

            while (j < right)
            {
                sorted[k] = arr[j];
                j++;
                k++;
            }

            for (int m = 0; m < sorted.Length; m++)
            {
                arr[left + m] = sorted[m];
            }

            return inversions;
        }
    }
}
