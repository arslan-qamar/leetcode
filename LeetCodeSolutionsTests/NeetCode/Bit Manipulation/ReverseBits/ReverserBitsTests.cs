using FluentAssertions;
using LeetCodeSolutions.NeetCode.Bit_Manipulation.ReverseBits;

namespace ReverseBits.Tests
{
    [TestClass()]
    public class ReverserBitsTests
    {
        [TestMethod()]
        public void ReverseBitsTest()
        {
            ReverserBits rb = new ReverserBits();
            rb.ReverseBits(21).Should().Be(2818572288);

        }
    }
}