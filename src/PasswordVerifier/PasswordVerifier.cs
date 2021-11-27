using KataExceptions;
using System;
using System.Collections.Generic;

namespace Katas.PasswordVerifier
{
    public class PasswordVerifier
    {
        private string password;
        private List<IPasswordRule> passwordRules;

        public PasswordVerifier(string password, List<IPasswordRule> passwordRules)
        {
            this.password = password;
            this.passwordRules = passwordRules;
        }

        public bool Verify() 
        {
            foreach(var rule in passwordRules)
            {
                 rule.Result(password);
            }
            return true;
        }
    }
}