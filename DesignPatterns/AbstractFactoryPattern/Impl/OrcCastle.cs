using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class OrcCastle : ICastle
    {
        private const string Description = "This is the Orc Castle!";

        public string GetDescription()
        {
            return Description;
        }
    }
}