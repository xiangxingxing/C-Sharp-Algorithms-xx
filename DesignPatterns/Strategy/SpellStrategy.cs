using System;

namespace DesignPatterns.Strategy
{
    public class SpellStrategy : IDragonSlayingStrategy
    {
        public void Execute()
        {
            Console.WriteLine("You cast the spell of disintegration and the dragon vaporizes in a pile of dust!");
        }
    }
}