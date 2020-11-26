using System;

namespace DesignPatterns.BridgePattern.Example2
{
    public class Mango : IMaterial
    {
        public void Activate()
        {
            Console.WriteLine("添加芒果");
        }

        public void Deactivate()
        {
            Console.WriteLine("去除芒果");
        }
    }
}