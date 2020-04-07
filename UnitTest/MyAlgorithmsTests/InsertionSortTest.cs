using System.Collections.Generic;
using System.Linq;
using MyAlgorithms.Sorting;
using DataStructures.Lists;
using Xunit;

namespace UnitTest.MyAlgorithmsTests
{
    public class InsertionSortTest
    {
        [Fact]
        public static void DoTest()
        {
            var list = new List<int>
            {
                23,
                42,
                4,
                16,
                8,
                15,
                9,
                55,
                0,
                34,
                12,
                2,
                25,
                42,
                46
            };

            list.InsertionSort();
            int[] expectedSortedList = {0, 2, 4, 8, 9, 12, 15, 16, 23, 25, 34, 42, 42, 46, 55};
            Assert.True(list.SequenceEqual(expectedSortedList));
        }
    }
}