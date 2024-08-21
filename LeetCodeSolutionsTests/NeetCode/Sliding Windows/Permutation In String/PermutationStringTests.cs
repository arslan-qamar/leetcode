using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Permutation_In_String.Tests
{
    [TestClass()]
    public class PermutationStringTests
    {
        [TestMethod()]
        public void CheckInclusionTest()
        {
            PermutationString.CheckInclusion("ab", "lecabee").Should().BeTrue();
            PermutationString.CheckInclusion("abc", "lecabee").Should().BeTrue();
            PermutationString.CheckInclusion("", "lecaabee").Should().BeFalse();
            PermutationString.CheckInclusion("aabee", "lecaabee").Should().BeTrue();
        }

        [TestMethod()]
        public void SpecialCase1()
        {
            // PermutationString.CheckInclusion("adc", "dcda").Should().BeTrue();
            PermutationString.CheckInclusion("abc", "bbbca").Should().BeTrue();
        }
    }
}