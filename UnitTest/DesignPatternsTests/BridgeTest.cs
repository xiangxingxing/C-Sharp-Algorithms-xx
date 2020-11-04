using System.Collections.Generic;
using DesignPatterns.BridgePattern;
using DesignPatterns.SingletonPattern;
using Xunit;

namespace UnitTest.DesignPatternsTests
{
    public class BridgeTest
    {
        [Fact]
        public void Bridge_Test()
        {
            var apple = new Apple();
            apple.MultiInstall(new List<SoftWare>
            {
                new Camera(),
                new Game(),
                new ThreeDTouch()
            });
            
            apple.Run();
        }

        [Fact]
        public void Single_Test()
        {
            var f1 = Singleton<FrenchPresident>.Instance();
            var f2 = Singleton<FrenchPresident>.Instance();
            Assert.Equal(f1.GetHashCode(), f2.GetHashCode());
        }
        
    }
}