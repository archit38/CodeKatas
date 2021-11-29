using KataExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PasswordVerifier
{
    public class PasswordSpecialCharRule : IPasswordRule
    {
        public int Count { get; set; }

        public bool Result(string password)
        {
            if (!password.Any(c => !char.IsLetterOrDigit(c)))
                throw new SpecialCharException($"Password should have a minimum of { Count } special character(s)");

            return true;
        }
    }
}
