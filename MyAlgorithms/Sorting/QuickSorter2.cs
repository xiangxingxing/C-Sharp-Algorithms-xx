using System.Collections.Generic;
using MyAlgorithms.Common;

namespace MyAlgorithms.Sorting
{
    public static class QuickSorter2
    {
        public static void QuickSort2<T>(this List<T> list)
        {
            var left = 0;
            var right = list.Count - 1;
            list.QuickSort2(left, right);
        }

        private static void QuickSort2<T>(this List<T> list, int left, int right, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;

            if (left < right)
            {
                var pivot = list.Partition(left, right, comparer);
                //list.QuickSort2(left, pivot, comparer); ❌ pivot每次得减少1
                //list.QuickSort2(pivot, right, comparer); ❌ pivot每次得减少1
                list.QuickSort2(left, pivot - 1, comparer);
                list.QuickSort2(pivot + 1, right, comparer);
            }
        }

        private static int Partition<T>(this List<T> list, int left, int right, Comparer<T> comparer)
        {
            var pivot = list[left];
            while (left < right)
            {
                while (left < right && comparer.Compare(list[right], pivot) >= 0)
                {
                    right--;
                }

                list[left] = list[right];

                while (left < right && comparer.Compare(list[left], pivot) <= 0)
                {
                    left++;
                }

                list[right] = list[left];
            }

            list[left] = pivot;
            return left;
        }
    }
}