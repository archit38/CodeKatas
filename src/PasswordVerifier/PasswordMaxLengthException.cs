using System;

namespace KataExceptions
{
    public class PasswordMaxLengthException : Exception
    {
        public PasswordMaxLengthException()
        {
        }

        public PasswordMaxLengthException(string message)
            : base(message)
        {
        }

        public PasswordMaxLengthException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}