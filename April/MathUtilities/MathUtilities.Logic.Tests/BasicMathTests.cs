using System;
using Xunit;

namespace MathUtilities.Logic.Tests
{
    public class BasicMathTests
    {
        /// <summary>
        /// Ensures that the add method successfully adds two integers
        /// </summary>
        [Fact]
        public void SuccessfulAdd()
        {
            var result = BasicMath.Add(22, 20);
            Assert.Equal(42, result);
        }

        [Fact]
        public void SuccessfulSubtract()
        {
            var result = BasicMath.Subtract(22, 20);
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(20, 10, 10)]
        [InlineData(5, 10, -5)]
        [InlineData(5, 5, 0)]
        public void Subtract(int x, int y, int expected)
        {
            var result = BasicMath.Subtract(x, y);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void DivideByNonZero()
        {
            var result = BasicMath.Divide(20, 10);
            Assert.Equal(2, result);
        }

        /// <summary>
        /// Ensures that an exception is thrown when the divisor is zero
        /// </summary>
        [Fact]
        public void DivideByZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BasicMath.Divide(20, 0));
        }
    }
}
