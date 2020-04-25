using MyAlgorithms.BroadView;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest.BroadViewTests
{
    public class InterviewerTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public InterviewerTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void NumberOfOne_Test()
        {
            var count = Interviewer.NumberOfOne(15);
            Assert.Equal(4, count);

            var count2 = Interviewer.NumberOfOne(16);
            Assert.Equal(1, count2);
        }

        [Fact]
        public void NumberMoreHalf_Test()
        {
            int[] array = {1, 2, 3, 2, 2, 2, 5, 4, 2};
            var num = Interviewer.NumberMoreHalf(array);
            Assert.Equal(2,num);
            
            int[] array2 = {1, 2, 3, 2, 5, 4, 2};
            var num2 = Interviewer.NumberMoreHalf(array2);
            Assert.Equal(0,num2);
        }

        [Fact]
        public void AdjustOrder_Test()
        {
            int[] array = {1, 22, 43, 25, 32, 20, 5, 49, 8};
            Interviewer.AdjustOrder(array);
            foreach (var i in array)
            {
                _testOutputHelper.WriteLine(i.ToString());
            }
        }
    }
}