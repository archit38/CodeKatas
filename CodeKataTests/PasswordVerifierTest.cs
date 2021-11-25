using KataExceptions;
using Katas;
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
            var passwordVerifier = new PasswordVerifier(password, 8);
            Assert.Throws<PasswordMaxLengthException>(() => passwordVerifier.Verify());
        }
    }
}