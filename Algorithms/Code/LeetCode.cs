using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.Code
{
    public class LeetCode
    {
        /// <summary>
        /// LeetCode16
        /// 给定一个包括 n 个整数的数组 nums 和 一个目标值 target。找出 nums 中的三个整数，使得它们的和与 target 最接近。
        /// 返回这三个数的和。假定每组输入只存在唯一答案。
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumClosest(int[] nums, int target) {
            var sum = int.MaxValue;
            if (nums == null) return sum;
            
            Array.Sort(nums);
            sum = nums[0] + nums[1] + nums[2];
            for (var i = 0; i < nums.Length; i++)
            {
                var left = i + 1;
                var right = nums.Length - 1;
                while (left < right)
                {
                    var pivot = nums[i] + nums[left] + nums[right];
                    sum = Math.Abs(pivot - target) < Math.Abs(sum - target) ? pivot : sum;
                    if (pivot < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return sum;
        }
    }
}