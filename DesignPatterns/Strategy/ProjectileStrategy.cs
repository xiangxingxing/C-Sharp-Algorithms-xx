using System;

namespace DesignPatterns.Strategy
{
    public class ProjectileStrategy : IDragonSlayingStrategy
    {
        public void Execute()
        {
            Console.WriteLine("You shoot the dragon with the magical crossbow and it falls dead on the ground!");
        }
    }
}