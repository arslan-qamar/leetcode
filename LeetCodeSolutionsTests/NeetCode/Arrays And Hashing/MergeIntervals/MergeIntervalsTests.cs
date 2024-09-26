using FluentAssertions;
using LeetCodeSolutions.NeetCode.Intervals.MergeIntervals;

namespace MergeIntervalsTests
{
    [TestClass()]
    public class MergeIntervalsTests
    {
        [TestMethod()]
        public void MergeTest()
        {
            MergeIntervals.Merge([[1, 3], [1, 5], [6, 7]]).Should().BeEquivalentTo(
                
                new int[][] {
                [1, 5], [6, 7]
                }

                );
        }


        [TestMethod()]
        public void MergeTest2()
        {
            MergeIntervals.Merge([[1, 2], [2, 3]]).Should().BeEquivalentTo(

                new int[][] {
                [1, 3]
                }

                );
        }
    }
}