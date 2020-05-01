using System.Collections.Generic;
using System.Linq;

namespace MyAlgorithms.LeetCode
{
    public static class LeetCoder
    {
        //leetCode09 判断一个整数是否是回文
        public static bool IsPalindrome(int number)
        {
            if (number < 0 || (number != 0 && number % 10 == 0))
            {
                return false;
            }

            var reversed = 0;
            while (number > reversed)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return reversed == number || reversed / 10 == number;
        }
        
        //leetCode22 数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
        public static List<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            if (n == 0)
            {
                return result;
            }
            Dfs("", n,n, result);
            return result;
        }

        private static void Dfs(string curStr, int left, int right, ICollection<string> result)
        {
            if (left > right)
            {
                return;
            }

            if (left == 0 && right == 0)
            {
                result.Add(curStr);
                return;
            }

            if (left > 0)
            {
                Dfs(curStr + "(", left - 1, right, result);
            }

            if (right > 0)
            {
                Dfs(curStr + ")", left, right - 1, result);
            }
        }
    }
}