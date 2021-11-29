using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataExceptions
{
    public class SpecialCharException : Exception
    {
        public SpecialCharException()
        {
        }

        public SpecialCharException(string message)
            : base(message)
        {
        }

        public SpecialCharException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
