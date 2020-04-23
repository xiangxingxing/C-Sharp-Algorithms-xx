using System;

namespace DesignPatterns.FactoryMethod
{
    public enum CountryType
    {
        China,
        Usa
    }

    public class FactoryMaker
    {
        public static ICountryFactory MakeFactory(CountryType type)
        {
            switch (type)
            {
                case CountryType.China:
                    return new ChinaFactory();
                case CountryType.Usa:
                    return new UsaFactory();
                default:
                    throw new ArgumentException("CountryType not supported.");
            }
        }
    }
}