using Xunit;

namespace TicTacToe.Logic.Tests
{
    public class SquareContentTests
    {
        /// <summary>
        /// Ensures that <see cref="SquareContent.Empty"/> has the value 0.
        /// </summary>
        /// <remarks>
        /// This value is important for the algorithms to work. Unit test
        /// ensures that nobody changes the value of <see cref="SquareContent.EMPTY"/>
        /// to a value other than 0.
        /// </remarks>
        [Fact]
        public void EmptyHasToBeZero()
        {
            Assert.Equal(0, SquareContent.EMPTY);
        }
    }
}