using System;
using System.Collections.Generic;

namespace MyAlgorithms.Search
{
    public static class BinarySearcher
    {
        public static int MyBinarySearch<T>(this List<T> list, T key, Comparer<T> comparer = null) where T : IComparable
        {
            var low = 0;
            var high = list.Count - 1;
            comparer = comparer ?? Comparer<T>.Default;
            var indexOfKey = list.MyBinarySearch(key, low, high, comparer);
            return indexOfKey;
        }

        //其实Comparer和 where T : IComparable有一个就行了
        private static int MyBinarySearch<T>(this List<T> list, T key, int low, int high, Comparer<T> comparer)
            where T : IComparable
        {
            while (low <= high)
            {
                var midIndex = (low + high) >> 1;
                var midVal = list[midIndex];
                if (comparer.Compare(midVal, key) < 0)
                {
                    low = midIndex + 1;
                }
                else if (comparer.Compare(midVal, key) > 0)
                {
                    high = midIndex - 1;
                }
                else
                {
                    return midIndex;
                }
            }

            return -(low + 1);
        }
    }
}