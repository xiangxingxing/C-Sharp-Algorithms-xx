using System;

namespace DesignPatterns.BridgePattern.Example2
{
    public class Sugar : IMaterial
    {
        public void Activate()
        {
            Console.WriteLine("添加白糖");
        }

        public void Deactivate()
        {
            Console.WriteLine("去除白糖");
        }
    }
}