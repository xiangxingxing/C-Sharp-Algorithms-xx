using System.Collections.Generic;
using System.Linq;
using MyAlgorithms.Sorting;
using Xunit;

namespace UnitTest.MyAlgorithmsTests
{
    public class MergeSortTest
    {
        [Fact]
        public void MergeSort_Test()
        {
            var numbersList = new List<int> { 23, 42, 4, 16, 8, 15, 3, 9, 55, 0, 34, 12, 2, 46, 25, 42 };

            var sortedList = numbersList.MergeSort();
            
            int[] expectedSortedList = { 0, 2, 3, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 42, 46, 55 };
            Assert.True(sortedList.SequenceEqual(expectedSortedList));
        }
    }
}