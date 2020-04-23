using DesignPatterns.FactoryMethod;
using Xunit;

namespace UnitTest.FactoryMethodTests
{
    public class FactoryTest
    {
        [Fact]
        public void Factory_Create_Test()
        {
            ICountryFactory factory = FactoryMaker.MakeFactory(CountryType.China);
            var league = factory.CreateLeague();
            var message = league.Display();
            Assert.Contains("logo is Yao", message);
            
            factory = FactoryMaker.MakeFactory(CountryType.Usa);
            var league2 = factory.CreateLeague();
            var message2 = league2.Display();
            Assert.True(message2 == "In NBA, logo is curry");
        }
    }
}