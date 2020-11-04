using System;
using System.Collections.Generic;
using System.Linq;
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.BridgePattern;
using DesignPatterns.ObservablePattern;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //ObservableTest();    
             // var res = int.TryParse("123", out var number);
             // Console.WriteLine($"{res}:{number}");
             //int[] temp = {};
             //int[] numbers = {1,2,3,4,5,6};
             //temp = numbers.Skip(0).Take(4).ToArray();
             //ObservableTest();
             //AbstractFactoryTest();
             StrategyTest();
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

        private static void AbstractFactoryTest()
        {
            var elf = FactoryMaker.MakeFactory(KingdomType.Elf);
            Console.WriteLine(elf.CreateArmy().GetDescription());
            Console.WriteLine(elf.CreateKing().GetDescription());
            Console.WriteLine(elf.CreateCastle().GetDescription());
            
            var orc = FactoryMaker.MakeFactory(KingdomType.Orc);
            Console.WriteLine(orc.CreateArmy().GetDescription());
            Console.WriteLine(orc.CreateKing().GetDescription());
            Console.WriteLine(orc.CreateCastle().GetDescription());
        }

        private static void StrategyTest()
        {
            var dragonSlayer = new DragonSlayer(new MeleeStrategy());
            dragonSlayer.Battle();
            
            dragonSlayer.ChangeStrategy(new ProjectileStrategy());
            dragonSlayer.Battle();
            
            dragonSlayer.ChangeStrategy(new SpellStrategy());
            dragonSlayer.Battle();

        }
    }
}