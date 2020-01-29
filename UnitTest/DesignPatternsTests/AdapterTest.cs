using DesignPatterns.AdapterPattern;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest.DesignPatternsTests
{
    public class AdapterTest
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public AdapterTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }
        [Fact]
        public void Adapter_Test()
        {
            var cbaPlayer = new CbaPlayer
            {
                Name = "Yao"
            };
            _testOutputHelper.WriteLine(cbaPlayer.Attack());
        }
    }
}