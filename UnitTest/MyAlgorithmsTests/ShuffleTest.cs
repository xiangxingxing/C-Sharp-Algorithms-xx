using System;
using System.Collections.Generic;
using MyAlgorithms.Shuffle;
using Xunit;
using Xunit.Abstractions;
using System.Linq;

namespace UnitTest.MyAlgorithmsTests
{
    public class ShuffleTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public ShuffleTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Shuffle_Test()
        {
            var sortedList = Enumerable.Range(1, 52);
            var array = sortedList.ToArray();
            Shuffler.Shuffle(array);
        }
    }
}