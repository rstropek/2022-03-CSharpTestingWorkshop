using MathUtilities.Logic;
using Xunit;
using System;

namespace MathUtilities.Tests
{
    public class BasicMathTests
    {
        [Fact]
        public void Add()
        {
            // Prepare
            const int x = 1;
            const int y = 2;

            // Act
            var result = BasicMath.Add(x, y);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void Div()
        {
            var result = BasicMath.Div(84, 2);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Div_by_zero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => BasicMath.Div(84, 0));
        }
    }
}