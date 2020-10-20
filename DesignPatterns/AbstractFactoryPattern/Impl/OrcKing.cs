using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class OrcKing : IKing
    {
        private const string Description = "This is the Orc King!";
        
        public string GetDescription()
        {
            return Description;
        }
    }
}