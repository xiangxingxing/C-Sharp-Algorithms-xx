namespace DesignPatterns.AbstractFactoryPattern.Interfaces
{
    public interface IKingdomFactory
    {
        IArmy CreateArmy();
        ICastle CreateCastle();
        IKing CreateKing();
    }
}