using FluentAssertions;

namespace Valid_Parentheses
{
    [TestClass()]
    public class ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            _ = ValidParentheses.IsValid("[]").Should().BeTrue();
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            _ = ValidParentheses.IsValid("([{}])").Should().BeTrue();
        }

        [TestMethod()]
        public void IsInValidTest()
        {
            _ = ValidParentheses.IsValid("[(])").Should().BeFalse();
        }



        [TestMethod()]
        public void IsInValidTestSpecial()
        {
            _ = ValidParentheses.IsValid("]").Should().BeFalse();
        }
    }
}