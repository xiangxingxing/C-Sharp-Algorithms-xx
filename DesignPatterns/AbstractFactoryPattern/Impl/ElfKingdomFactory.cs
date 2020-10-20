using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class ElfKingdomFactory : IKingdomFactory
    {
        public IArmy CreateArmy()
        {
            return new ElfArmy();
        }

        public ICastle CreateCastle()
        {
            return new ElfCastle();
        }

        public IKing CreateKing()
        {
            return new ElfKing();
        }
    }
}