using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas.PasswordVerifier
{
    public interface IPasswordRule
    {
        int Count { get; set; }

        public bool Result(string password);
    }
}
