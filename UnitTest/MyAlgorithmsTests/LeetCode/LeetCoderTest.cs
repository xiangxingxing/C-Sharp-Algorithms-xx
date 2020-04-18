using MyAlgorithms.LeetCode;
using Xunit;

namespace UnitTest.MyAlgorithmsTests.LeetCode
{
    public class LeetCoderTest
    {
        [Fact]
        public void LeetCode9_Test()
        {
            var input1 = 12321;
            var isPal1 = LeetCoder.IsPalindrome(input1);
            Assert.True(isPal1);

            var input2 = -12321;
            var isPal2 = LeetCoder.IsPalindrome(input2);
            Assert.False(isPal2);
        }
    }
}