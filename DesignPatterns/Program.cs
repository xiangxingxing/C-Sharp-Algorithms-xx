using System.Collections.Generic;
using DesignPatterns.BridgePattern;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
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
    }
}