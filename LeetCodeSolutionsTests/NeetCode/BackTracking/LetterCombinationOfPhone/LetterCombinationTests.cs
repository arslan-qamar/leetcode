using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.BackTracking.LetterCombinationOfPhone.Tests
{
    [TestClass()]
    public class LetterCombinationTests
    {
        [TestMethod()]
        public void LetterCombinationsTest()
        {
            LetterCombination lc = new();

            lc.LetterCombinations("34").Should().BeEquivalentTo(new List<string>() { "dg", "dh", "di", "eg", "eh", "ei", "fg", "fh", "fi" });
        }
    }
}