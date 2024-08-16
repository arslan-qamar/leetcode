using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Longest_Repeating_Substring_Replacement.Tests
{
    [TestClass()]
    public class LongestRepeatingSubstringReplaceTests
    {
        [TestMethod()]
        public void CharacterReplacementTest()
        {
            LongestRepeatingSubstringReplace.CharacterReplacement("XYYX", 2).Should().Be(4);

            LongestRepeatingSubstringReplace.CharacterReplacement("AAABABB", 1).Should().Be(5);

        }
    }
}