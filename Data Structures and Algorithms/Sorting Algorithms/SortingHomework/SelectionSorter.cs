namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> :
        ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }

            if (collection.Count <= 1)
            {
                return;
            }

            int n = collection.Count;

            for (int i = 0; i < n; i++)
            {
                int best = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (collection[j].CompareTo(collection[best]) < 0)
                    {
                        best = j;
                    }
                }

                if (best != i)
                {
                    var temp = collection[i];
                    collection[i] = collection[best];
                    collection[best] = temp;
                }
            }
        }
    }
}
