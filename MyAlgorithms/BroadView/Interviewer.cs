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
    }
}