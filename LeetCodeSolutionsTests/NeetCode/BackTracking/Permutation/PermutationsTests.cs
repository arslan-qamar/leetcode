using LeetCodeSolutions.NeetCode.BackTracking.Permutation;
using FluentAssertions;

namespace Permutation
{
    [TestClass()]
    public class PermutationsTests
    {
        [TestMethod()]
        public void PermuteTest()
        {
            Permutations.Permute(new int[] { 1, 2, 3 }).Should().BeEquivalentTo(

                new List<List<int>>() {

                    new List<int>() { 1, 2, 3 },
                    new List<int>() { 1, 3, 2 },
                    new List<int>() { 2,1,3 },
                    new List<int>() { 2,3,1 },
                    new List<int>() { 3,1,2 },
                    new List<int>() { 3,2,1 }
                }
                );
        }
    }
}