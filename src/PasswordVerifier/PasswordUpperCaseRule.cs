using KataExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PasswordVerifier
{
    public class PasswordUpperCaseRule : IPasswordRule
    {
        public int Count { get; set; }

        public bool Result(string password)
        {
            if (!password.Any(char.IsUpper))
                throw new UpperCaseException($"Password should have a minimum of { Count } upper case characters");

            return true;
        }
    }
}
