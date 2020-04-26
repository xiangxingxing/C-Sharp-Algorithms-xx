using System.Collections.Generic;

namespace MyAlgorithms.Common
{
    public static class Extensions
    {
        /// <summary>
        /// Swaps two values in an IList<T> collection given their indexes.
        /// </summary>
        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2 || firstIndex == secondIndex
            ) //This check is not required but Partition function may make many calls so its for perf reason
                return;

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }

        public static void AdjustMinHeap(this int[] array, int nodeIndex, int lastIndex)
        {
            var lChild = nodeIndex * 2 + 1;
            var rChild = lChild + 1;
            var smallest = nodeIndex;
            if (lChild <= lastIndex && array[lChild] < array[smallest])
            {
                smallest = lChild;
            }

            if (rChild <= lastIndex && array[rChild] < array[smallest])
            {
                smallest = rChild;
            }

            if (smallest != nodeIndex)
            {
                array.Swap(nodeIndex, smallest);
                array.AdjustMinHeap(smallest, lastIndex);
            }
        }

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