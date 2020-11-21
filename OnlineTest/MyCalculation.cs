using System;

namespace OnlineTest
{
    public class MyCalculation
    {
        public static void Main(string[] args)
        {
            DecimalOperation();
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
    }
}