using System;

namespace DesignPatterns.BridgePattern.Example2
{
    public class RedBean : IMaterial
    {
        public void Activate()
        {
            Console.WriteLine("添加红豆");
        }

        public void Deactivate()
        {
            Console.WriteLine("删除红豆");
        }
    }
}