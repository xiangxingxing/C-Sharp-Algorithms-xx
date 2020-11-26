using System.Collections.Generic;

namespace DesignPatterns.BridgePattern.Example2
{
    public interface IDrink
    {
        List<IMaterial> GetMaterials();
        void Make();
        void Remove();
    }
}