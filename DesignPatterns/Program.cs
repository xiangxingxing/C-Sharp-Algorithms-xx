using System;
using System.Collections.Generic;
using DesignPatterns.BridgePattern;
using DesignPatterns.ObservablePattern;

namespace DesignPatterns
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //ObservableTest();
            //var res = NumberOfOne(9);
            var res = (-1112 >> 1);
            Console.WriteLine(res);
        }

        private static void BridgeTest()
        {
            var apple = new Apple();
            apple.MultiInstall(new List<SoftWare>
            {
                new Camera(),
                new Game(),
                new ThreeDTouch()
            });

            var huaWei = new HuaWei();
            huaWei.Install(new Camera());

            apple.Run();
            huaWei.Run();
        }

        private static void ObservableTest()
        {
            Cat coffee = new CoffeeCat("Coffee");
            Cat boolCat = new BoolCat("BoolC");
            
            Mouse mikey = new MikeyMouse("Mikey", coffee);
            Mouse white = new WhiteMouse("white", coffee);
            Mouse boolMouse = new BoolMouse("BoolM", boolCat);
            
            coffee.OnCatAction();
            boolCat.OnCatAction();
        }

        private static void SymbolTest()
        {
            var number = 19;
            var value = (number & 1) == 1;// &1 =1表示为奇数
            Console.WriteLine($"{number} 为奇数:{value}");
            
            var number2 = 30;
            var value2 = (number2 & 1) == 1;
            Console.WriteLine($"{number2} 为奇数:{value2}");
        }

        private static int NumberOfOne(int n)
        {
            var count = 0;
            var flag = 1;
            while (flag > 0)
            {
                if ((flag & n) > 0)
                {
                    count++;
                }

                flag <<= 1;
            }

            return count;
        }
    }
}