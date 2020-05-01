using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void LeetCode22_Test()
        {
            var list = LeetCoder.GenerateParenthesis(3);
            var expected = new List<string>
            {
                "((()))",
                "(()())",
                "(())()",
                "()(())",
                "()()()"
            };

            Assert.True(expected.SequenceEqual(list));
        }
    }
}