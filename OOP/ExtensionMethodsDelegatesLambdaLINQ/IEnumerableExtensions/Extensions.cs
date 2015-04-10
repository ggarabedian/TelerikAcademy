namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> iEnumerable)
        {
            dynamic result = 0;

            foreach (var item in iEnumerable)
            {
                result += item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> iEnumerable)
        {
            dynamic result = 1;

            foreach (var item in iEnumerable)
            {
                result *= item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> iEnumerable)
        {
            dynamic result = iEnumerable.First();

            foreach (var item in iEnumerable)
            {
                if (result > item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> iEnumerable)
        {
            dynamic result = iEnumerable.First();

            foreach (var item in iEnumerable)
            {
                if (result < item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Average<T>(this IEnumerable<T> iEnumerable)
            where T : IConvertible, IComparable
        {
            return (dynamic)iEnumerable.Sum() / iEnumerable.Count();
        }
    }
}
