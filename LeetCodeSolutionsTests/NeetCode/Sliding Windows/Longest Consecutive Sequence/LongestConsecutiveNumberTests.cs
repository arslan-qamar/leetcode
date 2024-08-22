using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Longest_Consecutive_Sequence
{
    [TestClass()]
    public class LongestConsecutiveNumberTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            LongestConsecutiveNumber.LongestConsecutive(new int[] { 2, 20, 4, 10, 3, 4, 5 }).Should().Be(4);
            LongestConsecutiveNumber.LongestConsecutive(new int[] { 0, 3, 2, 5, 4, 6, 1, 1 }).Should().Be(7);
            LongestConsecutiveNumber.LongestConsecutive(new int[] { 0, 0, 0, 0, 0, 0 }).Should().Be(1);
            LongestConsecutiveNumber.LongestConsecutive(new int[] { 0, 0, 0, 0, 1, 0 }).Should().Be(2);
            LongestConsecutiveNumber.LongestConsecutive(new int[] { }).Should().Be(0);
            LongestConsecutiveNumber.LongestConsecutive(null).Should().Be(0);
        }
    }
}