using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking.DupCombinationSumII;

namespace DupCombinationSumII
{
    [TestClass()]
    public class DupCombinationSum2Tests
    {
        [TestMethod()]
        public void CombinationSum2Test()
        {
            DupCombinationSum2.CombinationSum2(new int[] { 9, 2, 2, 4, 6, 1, 5 }, 8).Should().BeEquivalentTo(

                new List<List<int>>()
                {
                    new List<int>() {1,2,5 },
                    new List<int>() {2,2,4 },
                    new List<int>() {2,6 }
                });
        }
    }
}