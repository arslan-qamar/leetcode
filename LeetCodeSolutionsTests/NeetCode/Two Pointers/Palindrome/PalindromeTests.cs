using FluentAssertions;

namespace Palindrome
{
    [TestClass()]
    public class PalindromeTests
    {
        [TestMethod()]
        public void IsPalindromeTest()
        {
            _ = Palindrome.IsPalindrome("Was it a car or a cat I saw?").Should().BeTrue();
            _ = Palindrome.IsPalindrome("tab a cat").Should().BeFalse();
            _ = Palindrome.IsPalindrome("").Should().BeTrue();
            _ = Palindrome.IsPalindrome(" ").Should().BeTrue();
            _ = Palindrome.IsPalindrome("  ").Should().BeTrue();
            _ = Palindrome.IsPalindrome(null).Should().BeFalse();
        }
    }
}