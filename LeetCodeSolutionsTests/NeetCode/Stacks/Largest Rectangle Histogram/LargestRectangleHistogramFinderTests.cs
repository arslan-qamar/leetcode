﻿using FluentAssertions;

namespace Largest_Rectangle_Histogram
{
    [TestClass()]
    public class LargestRectangleHistogramFinderTests
    {
        [TestMethod()]
        public void LargestRectangleAreaTest()
        {
            _ = LargestRectangleHistogramFinder.LargestRectangleArea(new int[] { 7, 1, 7, 2, 2, 4 }).Should().Be(8);
        }

        [TestMethod()]
        public void LargestRectangleAreaTest2()
        {
            _ = LargestRectangleHistogramFinder.LargestRectangleArea(new int[] { 1, 3, 7 }).Should().Be(7);
        }

    }
}