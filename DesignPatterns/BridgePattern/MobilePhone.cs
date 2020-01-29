using System;
using System.Collections.Generic;

namespace DesignPatterns.BridgePattern
{
    public abstract class MobilePhone
    {
        private readonly List<SoftWare> _softWares = new List<SoftWare>();

        public void Install(SoftWare softWare)
        {
            _softWares.Add(softWare);
        }

        public void MultiInstall(IEnumerable<SoftWare> softWares)
        {
            _softWares.AddRange(softWares);
        }

        public virtual void Run()
        {
            if (_softWares.Count == 0)
            {
                throw new Exception("no software installed.");
            }

            foreach (var softWare in _softWares)
            {
                softWare.Run();
            }
        }
    }

    public class Apple : MobilePhone
    {
        public override void Run()
        {
            Console.WriteLine("Apple phone initialize.");
            base.Run();
            Console.WriteLine("Apple initialized!");
        }
    }
    
    public class HuaWei : MobilePhone
    {
        public override void Run()
        {
            Console.WriteLine("HuaWei phone initialize.");
            base.Run();
            Console.WriteLine("HuaWei initialized!");
        }
    }
}