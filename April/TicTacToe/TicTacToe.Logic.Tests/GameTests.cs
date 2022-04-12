using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TicTacToe.Logic.Tests
{
    public class GameTests
    {
        [Fact]
        public void WinnerRowIntegrationTest()
        {
            var content = new BoardContent();
            content.Set(0, 0, SquareContent.X);
            content.Set(0, 1, SquareContent.O);
            content.Set(1, 0, SquareContent.X);
            content.Set(1, 1, SquareContent.O);
            content.Set(2, 0, SquareContent.X);
            // X is winner

            var game = new Game(content, "Player X", "Player Y");

            Assert.Equal("Player X", game.GetWinnerFromRows());
        }

        [Fact]
        public void WinnerRowUnitTestNaive()
        {
            var game = new Game(new BoardContentMock(), "Player X", "Player Y");
            Assert.Equal("Player X", game.GetWinnerFromRows());
        }

        private class BoardContentMock : IBoardContent
        {
            public byte[] Content => throw new NotImplementedException();

            public bool HasEmptySquares => throw new NotImplementedException();

            public byte Get(int col, int row)
            {
                if (row == 1) return SquareContent.X;
                return SquareContent.EMPTY;
            }

            public void Set(int col, int row, byte squareContent)
            {
                throw new NotImplementedException();
            }
        }

        [Fact]
        public void WinnerRowUnitTest()
        {
            var boardContentMock = new Mock<IBoardContent>();
            boardContentMock.Setup(x => x.Get(It.IsAny<int>(), 1)).Returns(SquareContent.X);

            var game = new Game(boardContentMock.Object, "Player X", "Player Y");
            Assert.Equal("Player X", game.GetWinnerFromRows());

            boardContentMock.VerifyAll();
        }
    }
}
