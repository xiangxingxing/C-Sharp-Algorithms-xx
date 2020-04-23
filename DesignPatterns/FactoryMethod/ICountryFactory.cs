namespace DesignPatterns.FactoryMethod
{
    public interface ICountryFactory
    {
        BasketballLeague CreateLeague();
    }
    
    internal class ChinaFactory : ICountryFactory
    {
        public BasketballLeague CreateLeague()
        {
            return new Cba();
        }
    }
    
    internal class UsaFactory : ICountryFactory
    {
        public BasketballLeague CreateLeague()
        {
            return new Nba();
        }
    }
}