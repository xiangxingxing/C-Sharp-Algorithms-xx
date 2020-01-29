using DesignPatterns.FactoryMethod;
using Xunit;

namespace UnitTest.FactoryMethodTests
{
    public class FactoryTest
    {
        [Fact]
        public void Factory_Create_Test()
        {
            ICountryFactory factory = new ChinaFactory();
            var league = factory.CreateLeague();
            var message = league.Display();
            Assert.True(message == "In CBA, logo is Yao");
            
            factory = new UsaFactory();
            var league2 = factory.CreateLeague();
            var message2 = league2.Display();
            Assert.True(message2 == "In NBA, logo is curry");
        }
    }
}