using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern.Impl
{
    public class OrcKingdomFactory : IKingdomFactory
    {
        public IArmy CreateArmy()
        {
            return new OrcArmy();
        }

        public ICastle CreateCastle()
        {
            return new OrcCastle();
        }

        public IKing CreateKing()
        {
            return new OrcKing();
        }
    }
}