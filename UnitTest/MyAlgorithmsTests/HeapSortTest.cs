using System.Collections.Generic;
using System.Linq;
using MyAlgorithms.Sorting;
using Xunit;
using Xunit.Abstractions;

namespace UnitTest.MyAlgorithmsTests
{
    public class HeapSortTest
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public HeapSortTest(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void MaxHeapSort_Test()
        {
            var numbersList = new List<int> {23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25, 42};
            numbersList.MaxHeapSort();
            int[] expectedSortedList = {0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 42, 46, 55};
            Assert.True(numbersList.SequenceEqual(expectedSortedList));
        }

        [Fact]
        public void MinHeapSort_Test()
        {
            var numbersList = new List<int> {23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25, 42};
            numbersList.MinHeapSort();
            int[] expectedSortedList = {0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 42, 46, 55};
            Assert.True(numbersList.SequenceEqual(expectedSortedList.Reverse()));
        }
    }
}