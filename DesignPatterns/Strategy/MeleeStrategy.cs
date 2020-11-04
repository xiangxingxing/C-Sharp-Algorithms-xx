using System;

namespace DesignPatterns.Strategy
{
    public class MeleeStrategy : IDragonSlayingStrategy
    {
        public void Execute()
        {
            Console.WriteLine("With your Excalibur you sever the dragon's head!");
        }
    }
}