using KataExceptions;
using Katas;
using Katas.PasswordVerifier;
using System.Collections.Generic;
using Xunit;

namespace KataTests
{
    public class PasswordVerifierTest
    {
        [Theory]
        [InlineData("12345")]
        [InlineData("1234567")]
        [InlineData("aghtyut")]
        [InlineData("123ab;N")]
        public void PassesLengthRule_should_throw_when_LessThan8Characters(string password)
        {
            var passwordVerifier = new PasswordVerifier(password, 
                                    new List<IPasswordRule> { new PasswordLengthRule() { Count = 8 } });

            Assert.Throws<PasswordMaxLengthException>(() => passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("12345678")]
        [InlineData("aghtyutjkjk")]
        [InlineData("123ab;Npoiy")]
        public void PassesLengthRule_should_pass_when_moreThan8Characters(string password)
        {
            var passwordVerifier = new PasswordVerifier(password,
                                    new List<IPasswordRule> { new PasswordLengthRule() { Count = 8 } });

            Assert.True(passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("lower case string")]
        public void UpperCaseRule_should_throw_when_noUpperCase(string password)
        {
            //var passwordVerifier = new PasswordVerifier(password, 8);
            //Assert.Throws<UpperCaseException>(() => passwordVerifier.Verify());
        }
    }
}