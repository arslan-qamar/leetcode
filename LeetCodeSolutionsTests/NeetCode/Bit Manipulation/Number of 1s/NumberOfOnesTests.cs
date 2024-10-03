using FluentAssertions;
using LeetCodeSolutions.NeetCode.Bit_Manipulation.Number_of_1s;

namespace Number_of_1s.Tests
{
    [TestClass()]
    public class NumberOfOnesTests
    {
        [TestMethod()]
        public void HammingWeightTest()
        {
            NumberOfOnes n1 = new NumberOfOnes();

            n1.HammingWeight(23).Should().Be(4);
        }
    }
}