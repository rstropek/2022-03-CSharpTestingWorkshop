using TicTacToe.Logic;
using Xunit;

namespace TicTacToe.Tests
{
    public class SquareContentTests
    {
        /// <summary>
        /// Ensures that nobody change the value of <see cref="SquareContent.EMPTY"/>
        /// </summary>
        /// <remarks>
        /// For our algorithms, it is important that <see cref="SquareContent.EMPTY"/>
        /// has the value zero. This unit test ensures that nobody changes it.
        /// </remarks>
        [Fact]
        public void EmptyHasToBeZero() => Assert.Equal(0, SquareContent.EMPTY);
    }
}