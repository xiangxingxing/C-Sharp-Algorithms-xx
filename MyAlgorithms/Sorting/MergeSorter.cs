using System.Collections.Generic;

namespace MyAlgorithms.Sorting
{
    public static class MergeSorter
    {
        public static List<T> MergeSort<T>(this List<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;

            return InternalMergeSort(collection, comparer);
        }

        private static List<T> InternalMergeSort<T>(List<T> collection, Comparer<T> comparer)
        {
            if (collection.Count < 2)
            {
                return collection;
            }

            var midIndex = collection.Count / 2;
            var leftCollection = collection.GetRange(0, midIndex);
            var rightCollection = collection.GetRange(midIndex, collection.Count - midIndex);

            leftCollection = InternalMergeSort(leftCollection, comparer);
            rightCollection = InternalMergeSort(rightCollection, comparer);

            return InternalMerge(leftCollection, rightCollection, comparer);
        }

        private static List<T> InternalMerge<T>(IReadOnlyList<T> leftCollection, IReadOnlyList<T> rightCollection, IComparer<T> comparer)
        {
            var left = 0;
            var right = 0;
            var index = 0;
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