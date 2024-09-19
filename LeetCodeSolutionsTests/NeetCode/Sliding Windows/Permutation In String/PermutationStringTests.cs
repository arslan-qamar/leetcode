using FluentAssertions;

namespace Permutation_In_String
{
    [TestClass()]
    public class PermutationStringTests
    {
        [TestMethod()]
        public void CheckInclusionTest()
        {
            _ = PermutationString.CheckInclusion("ab", "lecabee").Should().BeTrue();
            _ = PermutationString.CheckInclusion("abc", "lecabee").Should().BeTrue();
            _ = PermutationString.CheckInclusion("", "lecaabee").Should().BeFalse();
            _ = PermutationString.CheckInclusion("aabee", "lecaabee").Should().BeTrue();
        }

        [TestMethod()]
        public void SpecialCase1()
        {
            // PermutationString.CheckInclusion("adc", "dcda").Should().BeTrue();
            _ = PermutationString.CheckInclusion("abc", "bbbca").Should().BeTrue();
        }
    }
}