using KataExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PasswordVerifier
{
    public class PasswordLengthRule : IPasswordRule
    {
        public int Count { get; set; }

        public bool Result(string password)
        {
            if (password.Length < Count)
                throw new PasswordMaxLengthException($"Password should have a minimum of { Count } characters");

            return true;
        }
    }
}
