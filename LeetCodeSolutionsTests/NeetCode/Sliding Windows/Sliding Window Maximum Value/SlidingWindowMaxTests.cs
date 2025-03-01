﻿using FluentAssertions;

namespace Sliding_Window_Maximum_Value
{
    [TestClass()]
    public class SlidingWindowMaxTests
    {
        [TestMethod()]
        public void MaxSlidingWindowTest()
        {
            _ = SlidingWindowMax.MaxSlidingWindow(new int[] { 1, 2, 1, 0, 4, 2, 6 }, 3)
                .Should().BeEquivalentTo(new int[] { 2, 2, 4, 4, 6 }, options => options.WithStrictOrdering());
        }

        [TestMethod()]
        public void MaxSlidingWindowTestSpecial()
        {
            _ = SlidingWindowMax.MaxSlidingWindow(new int[] { 1, 2, 1, 0, 4, 2, 6 }, 0)
                .Should().BeEquivalentTo(new int[] { }, options => options.WithStrictOrdering());
        }

        [TestMethod()]
        public void MaxSlidingWindowTestSpecial2()
        {
            _ = SlidingWindowMax.MaxSlidingWindow(new int[] { 1, 2, 1, 0, 4, 2, 6 }, 1009)
                .Should().BeEquivalentTo(new int[] { }, options => options.WithStrictOrdering());
        }

        [TestMethod()]
        public void MaxSlidingWindowTestSpecial3()
        {
            _ = SlidingWindowMax.MaxSlidingWindow(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3)
                .Should().BeEquivalentTo(new int[] { 3, 3, 5, 5, 6, 7 }, options => options.WithStrictOrdering());
        }

    }
}