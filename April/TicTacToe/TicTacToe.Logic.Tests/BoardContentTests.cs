using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TicTacToe.Logic.Tests
{
    public class BoardContentTests
    {
        [Fact]
        public void ConstructorCreatesContentWithCorrectLength()
        {
            var content = new BoardContent();
            Assert.Equal(9, content.Content.Length);
        }

        [Fact]
        public void ConstructorThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(
                "other",
                () => new BoardContent(new byte[] { 1 }));
        }

        /// <summary>
        /// Ensures that the copy constructor COPIES the given source content
        /// </summary>
        /// <remarks>
        /// Lorem ipsum...
        /// </remarks>
        [Fact]
        public void ConstructorCopiesContent()
        {
            // Define a board content that should be copied
            var source = new byte[]
            {
                SquareContent.EMPTY, SquareContent.EMPTY, SquareContent.EMPTY,
                SquareContent.X, SquareContent.X, SquareContent.X,
                SquareContent.O, SquareContent.O, SquareContent.O,
            };

            // Use copy constructor to create board content instance
            var content = new BoardContent(source);

            // Manipulate original content that should have been copied
            source[0] = SquareContent.O;

            // Ensure that previous manipulation did not affect the copied content
            Assert.Equal(SquareContent.EMPTY, content.Content[0]);
        }

        [Fact]
        public void ContentGetterCopiesContent()
        {
            var board = new BoardContent();
            var c1 = board.Content;
            var c2 = board.Content;
            Assert.NotSame(c1, c2);
        }

        [Fact]
        public void ConstructorThrowsArgumentExceptionOnInvalidSquareContent()
        {
            Assert.Throws<ArgumentException>(
                "other",
                () => new BoardContent(new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 42 }));
        }
    }
}
