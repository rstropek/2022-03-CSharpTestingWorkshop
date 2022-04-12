using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TicTacToe.Logic.Tests")]

namespace TicTacToe.Logic
{
    public class BoardContent
    {
        /// <summary>
        /// Length of a side of our board
        /// </summary>
        /// <remarks>
        /// Note that the algorithms in this library do NOT support
        /// other side lenghts out of the box.
        /// </remarks>
        private const int SIDE_LENGTH = 3;
        private const int ARRAY_LENGTH = SIDE_LENGTH * SIDE_LENGTH;

        private byte[] content;

        public BoardContent()
        {
            content = new byte[ARRAY_LENGTH];
        }

        public BoardContent(byte[] other) : this()
        {
            if (other.Length != ARRAY_LENGTH)
            {
                throw new ArgumentException("Invalid board content", nameof(other));
            }

            // Ausprogrammierte Variante:
            //foreach(var square in other)
            //{
            //    if (square is not SquareContent.EMPTY 
            //        and not SquareContent.X 
            //        and not SquareContent.O)
            //    {
            //        throw new ArgumentException($"Invalid square content: {square}", nameof(other));
            //    }
            //}

            // Variante 2: Mit Language-integrated queries (LINQ)
            if (other.Any(square => square is not SquareContent.EMPTY
                and not SquareContent.X and not SquareContent.O))
            {
                throw new ArgumentException($"Invalid square content", nameof(other));
            }

            other.CopyTo(content, 0);
        }

        /// <summary>
        /// Gets a copy of the content of the board
        /// </summary>
        public byte[] Content => content.ToArray();

        public bool HasEmptySquares => 
            content.Any(square => square is SquareContent.EMPTY);
        
        internal static int CalculateIndex(int col, int row)
        {
            if (!(col is >= 0 and <= 2))
            {
                throw new ArgumentOutOfRangeException(nameof(col));
            }

            if (row is < 0 or > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(row));
            }
            
            return col + row * SIDE_LENGTH;
        }

        public byte Get(int col, int row) => content[CalculateIndex(col, row)];
        public void Set(int col, int row, byte squareContent)
        {
            if (squareContent is not SquareContent.EMPTY and not SquareContent.X and not SquareContent.O)
            {
                throw new ArgumentException($"Invalid square content: {squareContent}", nameof(squareContent));
            }

            content[CalculateIndex(col, row)] = squareContent;
        }
    }
}
