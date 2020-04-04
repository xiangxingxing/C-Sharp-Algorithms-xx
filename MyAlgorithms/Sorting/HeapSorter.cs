using System.Collections.Generic;
using MyAlgorithms.Common;

namespace MyAlgorithms.Sorting
{
    public static class HeapSorter
    {
        public static void MaxHeapSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            collection.HeapSortAscending(comparer);
        }

        public static void MinHeapSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            collection.HeapSortDescending(comparer);
        }

        // 大顶堆->升序排序
        private static void HeapSortAscending<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.BuildMaxHeap(comparer);
            var lastIndex = collection.Count - 1;

            // 交换堆顶[0]到末尾，重新调整大顶堆，结果升序排列
            while (lastIndex >= 0)
            {
                collection.Swap(0, lastIndex);
                lastIndex--;
                collection.HeapAdjust(0, lastIndex, comparer);
            }
        }

        // 构造初始大顶堆
        private static void BuildMaxHeap<T>(this IList<T> collection, Comparer<T> comparer)
        {
            var lastNodeWithChild = collection.Count / 2;
            var lastIndex = collection.Count - 1;
            // 从后往前遍历所有的分支节点，进行堆调整
            for (var i = lastNodeWithChild; i >= 0; i--)
            {
                collection.HeapAdjust(i, lastIndex, comparer);
            }
        }

        /// <summary>
        /// 大顶堆调整
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="node">需要调整的分支节点</param>
        /// <param name="lastIndex">数组的最大索引，为了限制左右孩子索引</param>
        /// <param name="comparer"></param>
        /// <typeparam name="T"></typeparam>
        private static void HeapAdjust<T>(this IList<T> collection, int node, int lastIndex, Comparer<T> comparer)
        {
            var leftChild = node * 2 + 1;
            var rightChild = leftChild + 1;
            // 与largest进行比较
            var largest = node;
            if (leftChild <= lastIndex && comparer.Compare(collection[leftChild], collection[largest]) > 0)
            {
                largest = leftChild;
            }

            if (rightChild <= lastIndex && comparer.Compare(collection[rightChild], collection[largest]) > 0)
            {
                largest = rightChild;
            }

            if (largest != node)
            {
                collection.Swap(largest, node);
                // largest位置的数值发生改变，需要再次堆调整
                collection.HeapAdjust(largest, lastIndex, comparer);
            }
        }


        // 小顶堆->降序排序
        private static void HeapSortDescending<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            comparer = comparer ?? Comparer<T>.Default;
            collection.BuildMinHeap(comparer);

            var lastIndex = collection.Count - 1;
            while (lastIndex >= 0)
            {
                collection.Swap(0, lastIndex);
                lastIndex--;
                collection.MinHeapAdjust(0, lastIndex, comparer);
            }
        }

        // 构造小顶堆
        private static void BuildMinHeap<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            var lastNodeWithChild = collection.Count / 2;
            var lastIndex = collection.Count - 1;
            for (var node = lastNodeWithChild; node >= 0; node--)
            {
                collection.MinHeapAdjust(node, lastIndex, comparer);
            }
        }

        // 小顶堆调整
        // node : 分支节点
        private static void MinHeapAdjust<T>(this IList<T> collection, int node, int lastIndex,
            Comparer<T> comparer = null)
        {
            var leftChild = node * 2 + 1;
            var rightChild = leftChild + 1;
            var smallest = node;
            if (leftChild <= lastIndex && comparer.Compare(collection[leftChild], collection[smallest]) < 0)
            {
                // collection.Swap(leftChild, smallest); ❌
                smallest = leftChild;
            }

            if (rightChild <= lastIndex && comparer.Compare(collection[rightChild], collection[smallest]) < 0)
            {
                //collection.Swap(rightChild, smallest); ❌
                smallest = rightChild;
            }

            if (smallest != node)
            {
                collection.Swap(smallest, node);
                collection.MinHeapAdjust(smallest, lastIndex, comparer);
            }
        }
    }
}