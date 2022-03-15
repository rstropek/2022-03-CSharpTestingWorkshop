using System.Runtime.Serialization;

namespace TicTacToe.Logic
{
    [Serializable]
    public class ContentNotEmptyException : Exception
    {
        public ContentNotEmptyException()
        {
        }

        public ContentNotEmptyException(string? message) : base(message)
        {
        }

        public ContentNotEmptyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ContentNotEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}