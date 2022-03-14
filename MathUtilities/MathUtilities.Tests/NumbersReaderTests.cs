using MathUtilities.Logic;
using Xunit;

namespace MathUtilities.Tests
{
    public class NumbersReaderTests
    {
        [Fact]
        public void ReadNumbers()
        {
            var reader = new NumbersReader();
            var numbers = reader.ReadNumbers();
            Assert.Equal(new[] { 1, 2, 2, 5 }, numbers);
        }
    }
}
