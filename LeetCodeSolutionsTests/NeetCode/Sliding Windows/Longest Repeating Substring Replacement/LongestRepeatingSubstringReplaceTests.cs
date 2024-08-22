using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Longest_Repeating_Substring_Replacement
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