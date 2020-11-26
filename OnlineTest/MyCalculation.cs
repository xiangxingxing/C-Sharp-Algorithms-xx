using System;

namespace OnlineTest
{
    public class MyCalculation
    {
        public static void Main(string[] args)
        {
            //DecimalOperation();
            StringsOperation();
        }
        
        /// <summary>
        /// https://www.ituring.com.cn/article/507147
        /// 浮点数和Decimal混合运算
        /// </summary>
        private static void DecimalOperation()
        {
            
            decimal m = 10m / 100m;
            Console.WriteLine(m);

            double d = 25d / 2d;//双精度浮点型:保留15位精度
            Console.WriteLine(d);
            
            float f = 5 / 3f;//单精度浮点型:保留7位精度
            Console.WriteLine(f);
        }

        private static void StringsOperation()
        {
            /*
            string a = new string("ab");
            string b = new string("ab");
            string aa = "ab";
            string bb = "ab";
            Console.WriteLine($"a == b => {a == b}");
            Console.WriteLine($"aa == bb => {aa == bb}");

            Console.WriteLine($"ReferenceEquals(a, b) => {ReferenceEquals(a, b)}");
            Console.WriteLine($"ReferenceEquals(aa, bb) => {ReferenceEquals(aa, bb)}");
            */
            
            //字符串比较：https://docs.microsoft.com/zh-cn/dotnet/csharp/how-to/compare-strings
            string a = "The computer ate my source code.";
            string b = "The computer ate my source code.";

            if (String.ReferenceEquals(a, b))
                Console.WriteLine("a and b are interned.");
            else
                Console.WriteLine("a and b are not interned.");

            string c = String.Copy(a);

            if (String.ReferenceEquals(a, c))
                Console.WriteLine("a and c are interned.");
            else
                Console.WriteLine("a and c are not interned.");
            
        }
    }
}