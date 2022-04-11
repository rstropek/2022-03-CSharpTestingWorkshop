using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TicTacToe.Tests")]

namespace TicTacToe.Logic
{
    public readonly struct BoardContent
    {
        internal readonly byte[] content;

        public BoardContent() : this(null) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="BoardContent"/> struct
        /// </summary>
        /// <param name="other">Optional board to copy, must be 9 element long</param>
        public BoardContent(byte[]? other)
        {
            content = new byte[3 * 3];
            if (other != null)
            {
                if (other.Length != 3 * 3)
                {
                    throw new ArgumentException("Board to copy has invalid length", nameof(other));
                }

                other.CopyTo(content, 0);
            }
        }

        /// <summary>
        /// Calculates the index in <see cref="content"/> based on row and column
        /// </summary>
        /// <param name="col">Index of the column (0..=2)</param>
        /// <param name="row">Index of the row (0..=2)</param>
        /// <returns>
        /// Index in <see cref="content"/>
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="col"/> or <paramref name="row"/> out of range
        /// </exception>
        internal static int CalculateIndex(int col, int row)
        {
            if (col is < 0 or > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(col));
            }

            if (row is < 0 or > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(row));
            }

            return CalculateIndexInternal(col, row);
        }

        private static int CalculateIndexInternal(int col, int row)
        {
            return row * 3 + col;
        }

        /// <summary>
        /// Sets a given square to a given value
        /// </summary>
        /// <param name="value">New value</param>
        /// <param name="col">Column of the square to set (0..=2)</param>
        /// <param name="row">Row of the square to set (0..=2)</param>
        /// <returns>
        /// New, updated board content
        /// </returns>
        /// <remarks>
        /// <paramref name="value"/> can be <see cref="SquareContent.X"/>
        /// or <see cref="SquareContent.O"/>.
        /// </remarks>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="col"/> or <paramref name="row"/> out of range
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="value"/> is not <see cref="SquareContent.X"/> 
        /// and not <see cref="SquareContent.O"/>
        /// </exception>
        public readonly BoardContent Set(byte value, int col, int row)
        {
            if (value is not (SquareContent.O or SquareContent.X))
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            // Do some magic to validate col and row

            var arrIx = CalculateIndexInternal(col, row);
            if (content[arrIx] != SquareContent.EMPTY)
            {
                throw new ContentNotEmptyException();
            }

            var newContent = new byte[3 * 3];
            content[..arrIx].CopyTo(newContent, 0);
            newContent[arrIx] = value;
            content[(arrIx + 1)..].CopyTo(newContent, arrIx + 1);

            return new BoardContent(newContent);
        }
    }
}
