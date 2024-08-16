using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Longest_Substring_Without_Duplicates.Tests
{
    [TestClass()]
    public class LongestSubstringTests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            LongestSubstring.LengthOfLongestSubstring("zxyzxyz").Should().Be(3);
        }

        [TestMethod()]
        public void LengthOfLongestSubstringxxxxxTest()
        {
            LongestSubstring.LengthOfLongestSubstring("xxxx").Should().Be(1);
        }

        [TestMethod()]
        public void LengthOfLongestSubstring123456789Test()
        {
            LongestSubstring.LengthOfLongestSubstring("123456789").Should().Be(9);
        }

        [TestMethod()]
        public void LengthOfLongestSubstringabcabcbbTest()
        {
            LongestSubstring.LengthOfLongestSubstring("abcabcbb").Should().Be(3);
        }

    }
}