using System;
using System.Collections.Generic;
using TicTacToe.Logic;
using Xunit;

// [assembly: CollectionBehavior(DisableTestParallelization = true)]

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

        [Theory]
        [InlineData(-1, 0, "col")]
        [InlineData(3, 0, "col")]
        [InlineData(0, -1, "row")]
        [InlineData(0, 3, "row")]
        public void Calculate_Index_Invalid_Col_Row(int col, int row, string paramName)
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                paramName,
                () => BoardContent.CalculateIndex(col, row));
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 1, 4)]
        [InlineData(2, 2, 8)]
        public void Calculate_Index(int col, int row, int expectedResult)
        {
            Assert.Equal(expectedResult, BoardContent.CalculateIndex(col, row));
        }

        [Theory]
        [MemberData(nameof(Squares))]
        public void CalculateIndexHandlesColRowCorrectly(int expectedIx, int col, int row)
            => Assert.Equal(expectedIx, BoardContent.CalculateIndex(col, row));

        public static IEnumerable<object[]> Squares()
        {
            var ix = 0;
            for (var row = 0; row < 3; row++)
            {
                for (var col = 0; col < 3; col++)
                {
                    yield return new object[] { ix++, col, row };
                }
            }
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        public void IndexerSetSuccess(int col, int row)
        {
            var content = new BoardContent();
            content = content.Set(SquareContent.X, col, row);
            Assert.Equal(SquareContent.X, content.content[BoardContent.CalculateIndex(col, row)]);

            var expected = new byte[3 * 3];
            expected[BoardContent.CalculateIndex(col, row)] = SquareContent.X;
            Assert.Equal(expected, content.content);
        }

        [Fact]
        public void SetInvalidValue()
            => Assert.Throws<ArgumentOutOfRangeException>("value", () => new BoardContent(null).Set(99, 1, 1));

    }
}
