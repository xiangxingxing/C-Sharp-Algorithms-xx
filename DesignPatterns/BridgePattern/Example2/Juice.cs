using System;
using System.Collections.Generic;

namespace DesignPatterns.BridgePattern.Example2
{
    public class Juice : IDrink
    {
        private readonly List<IMaterial> _materials;

        public Juice(List<IMaterial> materials)
        {
            _materials = materials;
        }

        public List<IMaterial> GetMaterials()
        {
            return _materials;
        }

        public void Make()
        {
            Console.WriteLine($"{this} prepares to add :");
            _materials.ForEach(m => m.Activate());
        }

        public void Remove()
        {
            Console.WriteLine($"{this} prepares to remove :");
            _materials.ForEach(m => m.Deactivate());
        }
    }
}