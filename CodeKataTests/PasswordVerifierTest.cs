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
        public void LengthRule_should_throw_when_LessThan8Characters(string password)
        {
            var passwordVerifier = new PasswordVerifier(password, 
                                    new List<IPasswordRule> { new PasswordLengthRule() { Count = 8 } });

            Assert.Throws<PasswordMaxLengthException>(() => passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("12345678")]
        [InlineData("aghtyutjkjk")]
        [InlineData("123ab;Npoiy")]
        public void LengthRule_should_pass_when_moreThan8Characters(string password)
        {
            var passwordVerifier = new PasswordVerifier(password,
                                    new List<IPasswordRule> { new PasswordLengthRule() { Count = 8 } });

            Assert.True(passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("lowercasestring")]
        [InlineData("lowercasestring234@")]
        public void UpperCaseRule_should_throw_when_noUpperCase(string password)
        {
            var passwordVerifier = new PasswordVerifier(password,  
                                    new List<IPasswordRule> { new PasswordUpperCaseRule() { Count = 1 } });

            Assert.Throws<UpperCaseException>(() => passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("Abctygdvdd")]
        [InlineData("AbcHello")]
        [InlineData("AbcHello234")]
        public void UpperCaseRule_should_pass_when_1UpperChar(string password)
        {
            var passwordVerifier = new PasswordVerifier(password,
                                        new List<IPasswordRule> 
                                        { 
                                            new PasswordLengthRule() { Count = 8 },
                                            new PasswordUpperCaseRule() { Count = 1 }
                                        });

            Assert.True(passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("lowercasestring")]
        [InlineData("lowercasestring234")]
        public void SpecialCharRule_should_throw_when_noSpecialCharRule(string password)
        {
            var passwordVerifier = new PasswordVerifier(password,
                                    new List<IPasswordRule> { new PasswordSpecialCharRule() { Count = 2 } });

            Assert.Throws<SpecialCharException>(() => passwordVerifier.Verify());
        }

        [Theory]
        [InlineData("Abctygdvd@d;")]
        [InlineData("Ab.cH,el-lo")]
        public void SpecialCharRule_should_pass_when_1specialChar(string password)
        {
            var passwordVerifier = new PasswordVerifier(password,
                                        new List<IPasswordRule>
                                        {
                                            new PasswordLengthRule() { Count = 8 },
                                            new PasswordUpperCaseRule() { Count = 1 },
                                            new PasswordSpecialCharRule() { Count = 2 }
                                        });

            Assert.True(passwordVerifier.Verify());
        }
    }
}