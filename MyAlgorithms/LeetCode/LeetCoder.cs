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
    }
}