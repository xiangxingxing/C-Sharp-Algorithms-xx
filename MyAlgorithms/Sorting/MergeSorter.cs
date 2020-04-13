using System.Collections.Generic;

namespace MyAlgorithms.Sorting
{
    /// <summary>
    /// 2路归并排序：将两个或两个以上的有序表组成一个新的有序表
    /// 稳定：不会改变相关关键字记录的相对次序
    /// 空间效率：辅助空间为n个单元 -> O(n)
    /// 时间效率：O(n*log2(n))
    /// </summary>
    public static class MergeSorter
    {
        public static List<T> MergeSort<T>(this List<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;

            return InternalMergeSort(collection, comparer);
        }

        // 分治
        private static List<T> InternalMergeSort<T>(List<T> collection, Comparer<T> comparer)
        {
            if (collection.Count < 2)
            {
                return collection;//仅含一个元素时返回
            }

            var midIndex = collection.Count / 2;
            var leftCollection = collection.GetRange(0, midIndex);
            var rightCollection = collection.GetRange(midIndex, collection.Count - midIndex);

            leftCollection = InternalMergeSort(leftCollection, comparer);
            rightCollection = InternalMergeSort(rightCollection, comparer);

            return InternalMerge(leftCollection, rightCollection, comparer);
        }

        // 将两个有序的顺序表合并成一个新的有序表
        private static List<T> InternalMerge<T>(IReadOnlyList<T> leftCollection, IReadOnlyList<T> rightCollection, IComparer<T> comparer)
        {
            var left = 0; // 第一个数组的索引
            var right = 0; // 第二个数组的索引
            var index = 0; // result数组的索引
            var length = leftCollection.Count + rightCollection.Count;
            var result = new List<T>(length);

            while (left < leftCollection.Count && right < rightCollection.Count)
            {
                if (comparer.Compare(leftCollection[left], rightCollection[right]) < 0)
                {
                    result.Insert(index++, leftCollection[left++]);
                }
                else
                {
                    result.Insert(index++, rightCollection[right++]);
                }
            }

            while (left < leftCollection.Count)
            {
                result.Insert(index++, leftCollection[left++]);
            }

            while (right < rightCollection.Count)
            {
                result.Insert(index++, rightCollection[right++]);
            }

            return result;
        }
    }
}