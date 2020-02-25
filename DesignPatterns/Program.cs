using System.Collections.Generic;
using DesignPatterns.BridgePattern;
using DesignPatterns.ObservablePattern;

namespace DesignPatterns
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            ObservableTest();
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
    }
}