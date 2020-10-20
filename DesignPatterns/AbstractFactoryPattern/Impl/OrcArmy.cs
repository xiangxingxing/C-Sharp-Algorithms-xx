using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class OrcArmy : IArmy
    {
        private const string Description = "This is the Orc Army!";

        public string GetDescription()
        {
            return Description;
        }
    }
}