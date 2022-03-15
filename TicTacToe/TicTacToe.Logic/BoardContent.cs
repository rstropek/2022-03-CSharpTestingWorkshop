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
    }
}
