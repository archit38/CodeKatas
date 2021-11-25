using KataExceptions;
using System;

namespace Katas
{
    public class PasswordVerifier
    {
        private int minLength = 8;
        private string password;

        public PasswordVerifier(string password, int minLength = 8)
        {
            this.minLength = minLength;
            this.password = password;
        }

        public bool Verify() => PassesLengthRule();

        private bool PassesLengthRule()
        {
            return true;
        }
    }
}