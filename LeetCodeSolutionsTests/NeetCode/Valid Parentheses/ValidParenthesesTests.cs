using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Valid_Parentheses
{
    [TestClass()]
    public class ValidParenthesesTests
    {
        [TestMethod()]
        public void IsValidTest()
        {
            ValidParentheses.IsValid("[]").Should().BeTrue();
        }

        [TestMethod()]
        public void IsValidTest2()
        {
            ValidParentheses.IsValid("([{}])").Should().BeTrue();
        }

        [TestMethod()]
        public void IsInValidTest()
        {
            ValidParentheses.IsValid("[(])").Should().BeFalse();
        }



        [TestMethod()]
        public void IsInValidTestSpecial()
        {
            ValidParentheses.IsValid("]").Should().BeFalse();
        }
    }
}