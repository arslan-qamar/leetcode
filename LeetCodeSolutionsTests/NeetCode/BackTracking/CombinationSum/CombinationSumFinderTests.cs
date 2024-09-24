using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.BackTracking.CombinationSum.Tests
{
    [TestClass()]
    public class CombinationSumFinderTests
    {
        [TestMethod()]
        public void CombinationSumTest()
        {
            CombinationSumFinder.CombinationSum(new int[] { 2, 6, 5, 9 }, 9).Should().BeEquivalentTo(
               new List<List<int>>()
               {
                    new List<int>() { 2,2,5 },
                    new List<int>() { 9 }
               });
        }
    }
}