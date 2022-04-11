using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathUtilities.Logic.Tests
{
    public class BasicStatisticsTests
    {
        [Fact]
        public void SumOfArray()
        {
            var result = BasicStatistics.SumOfNumbers(new [] { 0, 3, 7, 9 });
            Assert.Equal(19, result);
        }

        [Fact]
        public void SumOfList()
        {
            var result = BasicStatistics.SumOfNumbers(new List<int> { 0, 3, 7, 9 });
            Assert.Equal(19, result);
        }

        [Fact]
        public void SumOfEmptyList()
        {
            var result = BasicStatistics.SumOfNumbers(new List<int> { });
            Assert.Equal(0, result);
        }

        [Fact]
        public void SumOfNumbersFromReader()
        {
            var result = BasicStatistics.SumOfNumbersFromReader("testfile.txt", new NumbersReaderMock());
            Assert.Equal(6, result);
        }

        private class NumbersReaderMock : INumbersReader
        {
            public IEnumerable<int> ReadNumbersFromFile(string filePath)
            {
                Assert.Equal("testfile.txt", filePath);
                return new[] { 1, 2, 3 };
            }
        }
    }
}
