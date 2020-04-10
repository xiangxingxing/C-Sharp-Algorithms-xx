using System.Collections.Generic;
using MyAlgorithms.Search;
using Xunit;

namespace UnitTest.MyAlgorithmsTests.Search
{
    public class MyBinarySearchTest
    {
        [Fact]
        public void MyBinarySearch_Test()
        {
            var a = new List<char>
            {
                'I', 'L', 'a', 'c', 'h', 'n', 'p', 'x'
            };
            var indexOfc = a.MyBinarySearch('c');
            var indexOfn = a.MyBinarySearch('n');

            var indexOfx = a.MyBinarySearch('x');
            var indexOfZ = a.MyBinarySearch('Z'); // not exist
            var indexOfz = a.MyBinarySearch('z'); // not exist

            Assert.True(indexOfc == 3);
            Assert.True(indexOfn == 5);
            Assert.True(indexOfx == 7);

            Assert.True(indexOfZ == -3);
            Assert.True(indexOfz == -9);
        }
    }
}