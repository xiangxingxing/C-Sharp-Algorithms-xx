using System.Collections.Generic;
using DesignPatterns.BridgePattern;
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
    }
}