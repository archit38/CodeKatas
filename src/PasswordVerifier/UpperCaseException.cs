using System;

namespace KataExceptions
{
    public class UpperCaseException : Exception
    {
        public UpperCaseException()
        {
        }

        public UpperCaseException(string message)
            : base(message)
        {
        }

        public UpperCaseException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}