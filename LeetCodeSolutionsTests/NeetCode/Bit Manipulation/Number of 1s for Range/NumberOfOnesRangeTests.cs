using FluentAssertions;
using LeetCodeSolutions.NeetCode.Bit_Manipulation.Number_of_1s_for_Range;

namespace Number_of_1s_for_Range.Tests
{
    [TestClass()]
    public class NumberOfOnesRangeTests
    {
        [TestMethod()]
        public void CountBitsTest()
        {
            NumberOfOnesRange noo = new NumberOfOnesRange();

            noo.CountBits(4).Should().BeEquivalentTo(new int[] { 0, 1, 1, 2, 1 }, options => options.WithStrictOrdering());
        }

    }
}