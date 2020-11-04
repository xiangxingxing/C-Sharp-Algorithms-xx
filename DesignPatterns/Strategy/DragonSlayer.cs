namespace DesignPatterns.Strategy
{
    public class DragonSlayer
    {
        private IDragonSlayingStrategy _strategy;

        public DragonSlayer(IDragonSlayingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ChangeStrategy(IDragonSlayingStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Battle()
        {
            _strategy.Execute();
        }
    }
}