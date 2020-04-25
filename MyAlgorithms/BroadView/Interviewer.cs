using System;
using System.Linq;

namespace MyAlgorithms.BroadView
{
    public static class Interviewer
    {
        //No.15 二进制中1的个数
        //思路：设flag为1，和num & 运算并计数，flag << 1
        public static int NumberOfOne(int n)
        {
            var flag = 1;
            var count = 0;
            while (flag > 0)
            {
                if ((flag & n) > 0) //大于0
                {
                    count++;
                }

                flag <<= 1; //左移32次
            }

            return count;
        }
        
        //No.21 调整数组顺序使奇数位于偶数前面
        public static void AdjustOrder(int[] numbers)
        {
            var left = 0;
            var right = numbers.Length - 1;
            var pivot = numbers[left];
            while (left < right)
            {
                while (left < right && (numbers[right] & 1) == 0 )
                {
                    right--;
                }

                numbers[left] = numbers[right];
                while (left < right && (numbers[left] & 1) == 1)
                {
                    left++;
                }

                numbers[right] = numbers[left];
            }

            numbers[left] = pivot;
        }

        //No.39 数组中出现次数超过一半的数字: 遍历数组并借用times进行计数
        public static int NumberMoreHalf(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var times = 1;
            var result = numbers[0];
            for (var i = 1; i < numbers.Length; i++)
            {
                if (times == 0)
                {
                    result = numbers[i];
                    times = 1;
                }
                else if (numbers[i] == result)
                {
                    times++;
                }
                else
                {
                    times--;
                }
            }

            //检查result是否超过一半
            if (numbers.Count(i => i == result) <= (numbers.Length >> 1))
            {
                result = 0;
            }

            return result;
        }
    }
}