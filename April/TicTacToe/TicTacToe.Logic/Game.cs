using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Logic
{
    public class Game
    {
        private IBoardContent content;
        private string[] players;

        public Game(IBoardContent content, string player1, string player2)
        {
            players = new string[] { player1, player2 };
            this.content = content;
        }

        internal string GetPlayerByContent(int col, int row) => players[content.Get(col, row) - 1];

        internal string? GetWinnerFromRows()
        {
            for (byte row = 0; row < 3; row++)
            {
                if (content.Get(0, row) != SquareContent.EMPTY && content.Get(0, row) == content.Get(1, row)
                    && content.Get(0, row) == content.Get(2, row))
                {
                    return GetPlayerByContent(0, row);
                }
            }

            return null;
        }

        internal string? GetWinnerFromColumns()
        {
            for (byte col = 0; col < 3; col++)
            {
                if (content.Get(col, 0) != SquareContent.EMPTY && content.Get(col, 0) == content.Get(col, 1)
                    && content.Get(col, 0) == content.Get(col, 2))
                {
                    return GetPlayerByContent(col, 0);
                }
            }

            return null;
        }

        internal string? GetWinnerFromDiagonals()
        {
            if (content.Get(1, 1) != SquareContent.EMPTY
                && (content.Get(1, 1) == content.Get(0, 0) && content.Get(1, 1) == content.Get(2, 2)
                    || content.Get(1, 1) == content.Get(0, 2) && content.Get(1, 1) == content.Get(2, 0)))
            {
                return GetPlayerByContent(1, 1);
            }

            return null;
        }

        public string? GetWinner()
            => GetWinnerFromRows() ?? GetWinnerFromColumns() ?? GetWinnerFromDiagonals();

        public bool IsDraw() => !content.HasEmptySquares && GetWinner() == null;
    }
}
