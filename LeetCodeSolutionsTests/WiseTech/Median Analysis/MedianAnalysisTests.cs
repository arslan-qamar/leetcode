using FluentAssertions;

namespace WiseTechPractice.Problem_3.Tests
{
    [TestClass()]
    public class MedianAnalysisTests
    {
        [TestMethod()]
        public void LargestSubarrayWithMedianKTest()
        {
            List<int> input = [3, 4, 1, 5, 1, 2, 2, 2];

            _ = MedianAnalysis.getMaxSubsequenceLen(input).Should().BeEquivalentTo(
                new List<int>() { 5, 3, 1, 1, 1, 5, 5, 5 }
                );

        }

        [TestMethod()]
        public void LargestSubarrayWithMedianKTest2()
        {
            List<int> input = [1, 2, 2, 3, 4, 4, 4, 5, 6, 6, 6, 6];

            _ = MedianAnalysis.getMaxSubsequenceLen(input).Should().BeEquivalentTo(
                new List<int>() { 1, 5, 5, 7, 11, 11, 11, 7, 3, 3, 3, 3 }
                );
        }
    }
}