using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class ElfKing : IKing
    {
        private const string Description = "This is the Elven King!";
        
        public string GetDescription()
        {
            return Description;
        }
    }
}