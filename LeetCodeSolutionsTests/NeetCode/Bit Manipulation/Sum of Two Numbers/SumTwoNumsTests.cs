using FluentAssertions;
using LeetCodeSolutions.NeetCode.Bit_Manipulation.Sum_of_Two_Numbers;

namespace Sum_of_Two_Numbers.Tests
{
    [TestClass()]
    public class SumTwoNumsTests
    {
        [TestMethod()]
        public void GetSumTest()
        {
            SumTwoNums sn = new SumTwoNums();
            sn.GetSum(2, 5).Should().Be(7);
        }
    }
}