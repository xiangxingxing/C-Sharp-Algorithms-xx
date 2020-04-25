using System;

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
    }
}