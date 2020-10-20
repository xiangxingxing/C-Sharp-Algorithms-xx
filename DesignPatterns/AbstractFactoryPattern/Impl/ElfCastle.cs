using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class ElfCastle : ICastle
    {
        private const string Description = "This is the Elven Castle!";

        public string GetDescription()
        {
            return Description;
        }
    }
}