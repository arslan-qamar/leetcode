using FluentAssertions;

namespace Longest_Substring_Without_Duplicates
{
    [TestClass()]
    public class LongestSubstringTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            _ = LongestSubstring.LengthOfLongestSubstring("zxyzxyz").Should().Be(3);
        }

        [TestMethod()]
        public void LengthOfLongestSubstringxxxxxTest()
        {
            _ = LongestSubstring.LengthOfLongestSubstring("xxxx").Should().Be(1);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring123456789Test()
        {
            _ = LongestSubstring.LengthOfLongestSubstring("123456789").Should().Be(9);
        }

        [TestMethod()]
        public void LengthOfLongestSubstringabcabcbbTest()
        {
            _ = LongestSubstring.LengthOfLongestSubstring("abcabcbb").Should().Be(3);
        }

    }
}