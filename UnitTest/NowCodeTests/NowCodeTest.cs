using MyAlgorithms.BroadView;
using MyAlgorithms.NowCode;
using Xunit;

namespace UnitTest.NowCodeTests
{
    public class NowCodeTest
    {
        
        [Fact]
        public void CountOfPrimePairs()
        {
            var count = NowCoder.CountOfPrimePairs(10);
            Assert.Equal(2, count);
        }

        [Fact]
        public void IsPrime_Test()
        {
            Assert.True(NowCoder.IsPrime(5));
            Assert.True(!NowCoder.IsPrime(6));
        }

        [Fact]
        public void ThirdNumber_Test()
        {
            int[] number = {87, 45, 78, 32, 17, 65, 53, 09};
            var res = NowCoder.ThirdNumber(number);
            Assert.Equal(32, res);
        }
    }
}