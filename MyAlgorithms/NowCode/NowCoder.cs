using System;
using System.Linq;
using MyAlgorithms.Common;

namespace MyAlgorithms.NowCode
{
    public static class NowCoder
    {
                
        //给定一个正整数，编写程序计算有多少对质数的和等于输入的这个正整数，并输出结果
        public static int CountOfPrimePairs(int n)
        {
            var sum = 0;
            for (var i = 2; i <= (n >> 1); i++)
            {
                if (IsPrime(i) && IsPrime(n - i))
                {
                    sum += 1;
                }
            }

            return sum;
        }
        
        public static bool IsPrime(int n)
        {
            //i到 n的根号方
            for (var i = 2; i <= Math.Sqrt(n); i++)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
        
        // 实现两个单向有序链表的合并
        // public static link MergeTwoList(ListNode pHead1, ListNode pHead2)
        // {
        //     
        // }
        
        //给定一个无序的整型数组A[n],数组大小大于等于3,允许有值相同的元素;请设计算法找到该数组排序后第三大的元素值并输出.
        public static int ThirdNumber(int[] array)
        {
            //先取 n - k + 1个元素构造小根堆
            var length = array.Length - 2;//k - 1
            var minHeap = array.Skip(0).Take(length).ToArray();
            var lastIndex = minHeap.Length - 1;
            var lastNodeWithChild = lastIndex >> 1;
            for (var node = lastNodeWithChild; node >= 0 ; node--)
            {
                minHeap.AdjustMinHeap(node, lastIndex);
            }
            
            //剩余2个元素分别和堆顶比较，小于堆顶则忽略，大于就替代并且重新调整
            for (var i = length; i < array.Length; i++)
            {
                if (array[i] < minHeap[0])
                {
                    continue;
                }

                minHeap[0] = array[i];
                minHeap.AdjustMinHeap(0, lastIndex);
            }

            return minHeap[0];
        }
        
    }
}