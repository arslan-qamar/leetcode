using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Stacks.Largest_Rectangle_Histogram.Tests
{
    [TestClass()]
    public class LargestRectangleHistogramFinderTests
    {
        [TestMethod()]
        public void LargestRectangleAreaTest()
        {
            LargestRectangleHistogramFinder.LargestRectangleArea(new int[] { 7, 1, 7, 2, 2, 4 }).Should().Be(8);
        }

        [TestMethod()]
        public void LargestRectangleAreaTest2()
        {
            LargestRectangleHistogramFinder.LargestRectangleArea(new int[] { 1, 3, 7 }).Should().Be(7);
        }

    }
}