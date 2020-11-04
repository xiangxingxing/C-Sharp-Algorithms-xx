using System.Collections.Generic;

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


        // 按某种规则，将列表划分为前一半和后一半的类型
        private static void QuickSort2<T>(this List<T> list, int left, int right, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            var start = left;
            var end = right;
            var pivot = list[left];
            while (left < right) // 无等号
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
            if (start < end)
            {
                list.QuickSort2(left + 1, end);
                list.QuickSort2(start , left - 1);
            }
        }
    }
}