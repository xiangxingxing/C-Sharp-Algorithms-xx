using System.Collections.Generic;
using MyAlgorithms.Common;

namespace MyAlgorithms.Sorting
{
    public static class BubbleSorter
    {
        public static void BubbleSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.BubbleSortAscending(comparer);
        }

        private static void BubbleSortAscending<T>(this IList<T> collection, IComparer<T> comparer)
        {
            for (var i = 0; i < collection.Count; i++)
            {
                for (var j = 0; j < collection.Count - 1 - i; j++)
                {
                    if (comparer.Compare(collection[j], collection[j + 1]) > 0)
                    {
                        collection.Swap(j, j + 1);
                    }
                }
            }
        }
    }
}