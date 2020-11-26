using System;

namespace DesignPatterns.BridgePattern.Example2
{
    public class Pearl : IMaterial
    {
        public void Activate()
        {
            Console.WriteLine("添加珍珠");
        }

        public void Deactivate()
        {
            Console.WriteLine("去除珍珠");
        }
    }
}