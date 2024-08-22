using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Two_Integer_Sum_II
{
    [TestClass()]
    public class TwoIntegerSumIITests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            TwoIntegerSumII.TwoSum(new int[] { 1, 2, 3, 4 }, 3).Should().BeEquivalentTo(new int[] { 1, 2 }, options => options.WithStrictOrdering());
            TwoIntegerSumII.TwoSum(new int[] { }, 3).Should().BeEquivalentTo(new int[] { 0, 0 }, options => options.WithStrictOrdering());
            TwoIntegerSumII.TwoSum(new int[] { 1, 2, 3, 4 }, 100).Should().BeEquivalentTo(new int[] { 0, 0 }, options => options.WithStrictOrdering());
            TwoIntegerSumII.TwoSum(new int[] { 1, 2, 3, 100 }, 100).Should().BeEquivalentTo(new int[] { 0, 0 }, options => options.WithStrictOrdering());
            TwoIntegerSumII.TwoSum(new int[] { -1, 2, 3, 101 }, 100).Should().BeEquivalentTo(new int[] { 1, 4 }, options => options.WithStrictOrdering());
            TwoIntegerSumII.TwoSum(new int[] { -1, 2, 3, 101 }, 5).Should().BeEquivalentTo(new int[] { 2, 3 }, options => options.WithStrictOrdering());
        }
    }
}