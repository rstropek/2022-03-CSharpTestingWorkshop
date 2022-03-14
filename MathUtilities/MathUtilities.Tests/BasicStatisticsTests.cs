using MathUtilities.Logic;
using Xunit;

namespace MathUtilities.Tests
{
    public class BasicStatisticsTests
    {
        [Fact]
        public void Sum()
        {
            var stat = new BasicStatistics();
            Assert.Equal(10, stat.SumOfNumbers(new[] { 1, 2, 2, 5 }));
        }

        [Fact]
        public void Sum_from_file()
        {
            var stat = new BasicStatistics();
            Assert.Equal(10, stat.SumOfNumbersFromFile());
        }
    }
}
