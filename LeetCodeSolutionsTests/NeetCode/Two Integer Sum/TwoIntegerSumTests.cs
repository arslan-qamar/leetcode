using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Two_Integer_Sum.Tests
{
    [TestClass()]
    public class TwoIntegerSumTests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            CollectionAssert.AreEqual(TwoIntegerSum.TwoSum(new int[] { 3, 4, 5, 6 }, 7), new int[] { 0, 1 });
        }


        [TestMethod()]
        public void TwoSumTestReturnsDefault()
        {
            CollectionAssert.AreEqual(TwoIntegerSum.TwoSum(new int[] { 3, 4, 5, 6 }, 77), new int[] { 0, 0 });
        }
    }
}