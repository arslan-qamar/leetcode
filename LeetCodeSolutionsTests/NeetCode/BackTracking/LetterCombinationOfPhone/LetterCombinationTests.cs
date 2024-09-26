using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking.LetterCombinationOfPhone;

namespace LetterCombinationOfPhone
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