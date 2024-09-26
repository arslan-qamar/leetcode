using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking.DupSubSets;

namespace DupSubSetsTests
{
    [TestClass()]
    public class DupSubSetsTests
    {
        [TestMethod()]
        public void SubsetsWithDupTest()
        {
            DupSubSets.SubsetsWithDup(new int[] { 1, 2, 1 }).Should().BeEquivalentTo(
                new List<List<int>>()
                {
                    new List<int>() {},
                    new List<int>() {1},
                    new List<int>() {1,2},
                    new List<int>() {1,1},
                    new List<int>() {1,2,1},
                    new List<int>() {2},
                });
        }
    }
}