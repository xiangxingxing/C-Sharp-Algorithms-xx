namespace DesignPatterns.FactoryMethod
{
    public interface ICountryFactory
    {
        BasketballLeague CreateLeague();
    }
    
    public class ChinaFactory : ICountryFactory
    {
        public BasketballLeague CreateLeague()
        {
            return new Cba();
        }
    }
    
    public class UsaFactory : ICountryFactory
    {
        public BasketballLeague CreateLeague()
        {
            return new Nba();
        }
    }
}