using System;

namespace DesignPatterns.FactoryMethod
{
    public abstract class BasketballLeague
    {
        protected abstract string Logo { get; set; }
        public abstract string Display();
    }

    public class Nba : BasketballLeague
    {
        protected sealed override string Logo { get; set; }

        public Nba()
        {
            Logo = "curry";
        }
        public override string Display()
        {
            return $"In NBA, logo is {Logo}";
        }
    }

    public class Cba : BasketballLeague
    {
        protected sealed override string Logo { get; set; }

        public Cba()
        {
            Logo = "Yao";
        }

        public override string Display()
        {
            return $"In CBA, logo is {Logo}";
        }
    }
}