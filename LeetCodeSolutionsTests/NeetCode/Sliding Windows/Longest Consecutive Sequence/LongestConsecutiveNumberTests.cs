using FluentAssertions;

namespace Longest_Consecutive_Sequence
{
    [TestClass()]
    public class LongestConsecutiveNumberTests
    {
        [TestMethod()]
        public void LongestConsecutiveTest()
        {
            _ = LongestConsecutiveNumber.LongestConsecutive(new int[] { 2, 20, 4, 10, 3, 4, 5 }).Should().Be(4);
            _ = LongestConsecutiveNumber.LongestConsecutive(new int[] { 0, 3, 2, 5, 4, 6, 1, 1 }).Should().Be(7);
            _ = LongestConsecutiveNumber.LongestConsecutive(new int[] { 0, 0, 0, 0, 0, 0 }).Should().Be(1);
            _ = LongestConsecutiveNumber.LongestConsecutive(new int[] { 0, 0, 0, 0, 1, 0 }).Should().Be(2);
            _ = LongestConsecutiveNumber.LongestConsecutive(new int[] { }).Should().Be(0);
            _ = LongestConsecutiveNumber.LongestConsecutive(null).Should().Be(0);
        }
    }
}