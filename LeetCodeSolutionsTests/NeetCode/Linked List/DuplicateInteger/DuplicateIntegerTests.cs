using FluentAssertions;

namespace DuplicateInteger.Tests
{
    [TestClass()]
    public class DuplicateIntegerTests
    {
        [TestMethod()]
        public void FindDuplicateTest()
        {
            _ = DuplicateInteger.FindDuplicate(new int[] { 1, 2, 3, 2, 2 }).Should().Be(2);
        }

        [TestMethod()]
        public void FindDuplicateTest2()
        {
            _ = DuplicateInteger.FindDuplicate(new int[] { 1, 2, 3, 4, 4 }).Should().Be(4);
        }
    }
}