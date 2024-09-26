using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking;

namespace Subsets
{
    [TestClass()]
    public class SubSetsTests
    {
        [TestMethod()]
        public void SubsetsTest()
        {

            SubSets.Subsets(new int[] { 1, 2, 3 }).Should().BeEquivalentTo(

                new List<List<int>>()
                {
                    new List<int>() { },
                    new List<int>() { 1 },
                    new List<int>() { 2 },
                    new List<int>() { 1, 2 },
                    new List<int>() { 3 },
                    new List<int>() { 1, 3 },
                    new List<int>() { 2, 3 },
                    new List<int>() { 1, 2, 3 },
                });
        }
    }
}