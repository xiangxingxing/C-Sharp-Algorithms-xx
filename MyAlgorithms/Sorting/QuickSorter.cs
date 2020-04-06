using System.Collections.Generic;
using MyAlgorithms.Common;

namespace MyAlgorithms.Sorting
{
    public static class QuickSorter
    {
        public static void QuickSort<T>(this List<T> list)
        {
            var left = 0;
            var right = list.Count - 1;
            list.QuickSort(left, right);
        }
        
        public static void QuickSortDescending<T>(this List<T> list, Comparer<T> comparer = null)
        {
            var left = 0;
            var right = list.Count - 1;
            comparer = comparer ?? Comparer<T>.Default;
            list.QuickSortDescending(left, right, comparer);
        }

        public static void QuickSort<T>(this List<T> list, int startIndex, int endIndex, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            list.QuickSortAscending(startIndex, endIndex, comparer);
        }

        private static void QuickSortAscending<T>(this List<T> list, int left, int right, Comparer<T> comparer)
        {
            var i = left;
            var j = right;
            // var pivot = (left + right) / 2; ❌ 这样写，在判断语句中取list[pivot]时，该位置的值可能会变；
            var pivot = list[(left + right) / 2]; // 应该和最初始的这个值 "list[(left + right) / 2]"进行比较

            while (i <= j) // 使用等号 =
            {
                while (comparer.Compare(list[i], pivot) < 0)
                {
                    i++;
                }

                while (comparer.Compare(list[j], pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    list.Swap(i, j);
                    i++;
                    j--;
                }
            }

            if (i < right)
            {
                list.QuickSortAscending(i, right, comparer);
            }

            if (j > left)
            {
                list.QuickSortAscending(left, j, comparer);
            }
        }

        private static void QuickSortDescending<T>(this List<T> list, int left, int right, Comparer<T> comparer)
        {
            var i = left;
            var j = right;
            //var pivot = (left + right) / 2; ❌ 这样写，在判断语句中取list[pivot]时，该位置的值可能会变；
            var pivot = list[(left + right) / 2];

            while (i <= j)
            {
                while (comparer.Compare(list[i], pivot) > 0)
                {
                    i++;
                }

                while (comparer.Compare(list[j], pivot) < 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    list.Swap(i, j);
                    i++;
                    j--;
                }
            }

            if (i < right)
            {
                list.QuickSortDescending(i, right, comparer);
            }

            if (j > left)
            {
                list.QuickSortDescending(left, j, comparer);
            }
        }
    }
}