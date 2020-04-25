using System.Collections;
using System.Collections.Generic;

namespace MyAlgorithms.BroadView
{
    public static class Helper
    {
        public static int Partition<T>(this T[] array, int left, int right, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            var pivot = array[left];
            while (left < right)
            {
                while (left < right && comparer.Compare(pivot, array[right]) <= 0)
                {
                    right--;
                }

                array[left] = array[right];

                while (left < right && comparer.Compare(pivot, array[left]) >= 0)
                {
                    left++;
                }

                array[right] = array[left];
            }

            array[left] = pivot;
            return left;
        }
    }
}