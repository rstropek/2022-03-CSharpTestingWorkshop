using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Logic;
using Xunit;

namespace TicTacToe.Tests
{
    public class BoardContentTests
    {
        [Fact]
        public void CreateEmptyBoard()
        {
            var board = new BoardContent();
            Assert.Equal(9, board.content.Length);
            Assert.All(board.content, square => Assert.Equal(SquareContent.EMPTY, square));
        }

        [Fact]
        public void CopyBoard()
        {
            var board = new BoardContent();
            board.content[4] = SquareContent.X;

            var otherBoard = new BoardContent(board.content);
            Assert.Equal(board.content, otherBoard.content);

            board.content[4] = SquareContent.O;
            Assert.NotEqual(board.content, otherBoard.content);
        }

        [Fact]
        public void Try_Copy_Board_Of_Invalid_Length()
        {
            Assert.Throws<ArgumentException>(() => new BoardContent(new[] { SquareContent.X }));
        }
    }
}
