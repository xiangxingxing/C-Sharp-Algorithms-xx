using System;
using DesignPatterns.AbstractFactoryPattern.Impl;
using DesignPatterns.AbstractFactoryPattern.Interfaces;

namespace DesignPatterns.AbstractFactoryPattern
{
    public enum KingdomType
    {
        Elf,
        Orc
    }
    
    public class FactoryMaker
    {
        public static IKingdomFactory MakeFactory(KingdomType type)
        {
            switch (type)
            {
                case KingdomType.Elf:
                    return new ElfKingdomFactory();
                case KingdomType.Orc:
                    return new OrcKingdomFactory();
                default:
                    throw new ArgumentException("KingdomType not supported.");
            }
        }
        
    }
}