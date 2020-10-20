using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class ElfArmy : IArmy
    {
        private const string Description = "This is the Elven Army!";

        public string GetDescription()
        {
            return Description;
        }
    }
}