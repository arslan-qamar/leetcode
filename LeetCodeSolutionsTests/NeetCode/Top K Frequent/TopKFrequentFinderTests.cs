﻿using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Top_K_Frequent.Tests
{
    [TestClass()]
    public class TopKFrequentFinderTests
    {
        [TestMethod()]
        public void TopKFrequentTest()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 1, 2, 2, 3, 3, 3 }, 2);

            result.Should().BeEquivalentTo(new int[] { 2, 3 });
        }

        [TestMethod()]
        public void TopKFrequentTestRepeat7()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 7, 7, 7 }, 1);

            result.Should().BeEquivalentTo(new int[] { 7 });
        }


        [TestMethod()]
        public void TopKFrequentTest12()
        {
            int[] result = TopKFrequentFinder.TopKFrequent(new int[] { 1, 2 }, 2);

            result.Should().BeEquivalentTo(new int[] { 1, 2 });
        }
    }
}