using FluentAssertions;

namespace Longest_Repeating_Substring_Replacement
{
    [TestClass()]
    public class LongestRepeatingSubstringReplaceTests
    {
        [TestMethod()]
        public void CharacterReplacementTest()
        {
            _ = LongestRepeatingSubstringReplace.CharacterReplacement("XYYX", 2).Should().Be(4);

            _ = LongestRepeatingSubstringReplace.CharacterReplacement("AAABABB", 1).Should().Be(5);

        }
    }
}