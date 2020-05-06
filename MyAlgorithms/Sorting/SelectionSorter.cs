using System.Collections.Generic;
using MyAlgorithms.Common;

namespace MyAlgorithms.Sorting
{
    public static class SelectionSorter
    {
        public static void SelectionSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.SelectionSortAscending(comparer);
        }

        public static void SelectionSortAscending<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            for (var i = 0; i < collection.Count; i++)
            {
                var min = i;
                for (var j = i + 1; j < collection.Count; j++)
                {
                    if (comparer.Compare(collection[j], collection[min]) < 0)
                    {
                        min = j;
                    }
                }

                collection.Swap(min, i);
            }
        }
    }
}