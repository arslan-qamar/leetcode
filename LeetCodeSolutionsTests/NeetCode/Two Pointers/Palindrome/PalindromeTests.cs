using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Palindrome.Tests
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            Palindrome.IsPalindrome("Was it a car or a cat I saw?").Should().BeTrue();
            Palindrome.IsPalindrome("tab a cat").Should().BeFalse();
            Palindrome.IsPalindrome("").Should().BeTrue();
            Palindrome.IsPalindrome(" ").Should().BeTrue();
            Palindrome.IsPalindrome("  ").Should().BeTrue();
            Palindrome.IsPalindrome(null).Should().BeFalse();
        }
    }
}