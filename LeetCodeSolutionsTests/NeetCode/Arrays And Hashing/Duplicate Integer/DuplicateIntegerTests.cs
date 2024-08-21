using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Duplicate_Integer.Tests
{
    [TestClass()]
    public class DuplicateIntegerTests
    {
        [TestMethod()]
        public void HasNoDuplicateTest()
        {
            Assert.IsFalse(DuplicateInteger.HasDuplicates(new int[] { 1, 2, 3, 4 }));
        }

        [TestMethod()]
        public void HasDuplicateTest()
        {
            Assert.IsTrue(DuplicateInteger.HasDuplicates(new int[] { 1, 1, 2, 3, 3, 4 }));
        }
    }
}