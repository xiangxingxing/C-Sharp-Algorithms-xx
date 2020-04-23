using MyAlgorithms.BroadView;
using Xunit;

namespace UnitTest.BroadViewTests
{
    public class InterviewerTest
    {
        [Fact]
        public void NumberOfOne_Test()
        {
            var count = Interviewer.NumberOfOne(15);
            Assert.Equal(4, count);

            var count2 = Interviewer.NumberOfOne(16);
            Assert.Equal(1, count2);
        }
    }
}