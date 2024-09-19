using FluentAssertions;

namespace Heaps_And_Priority_Queue.Tests
{
    [TestClass()]
    public class KthLargestTests
    {
        [TestMethod()]
        public void AddTest()
        {
            KthLargest kthLargest = new(3, new int[] { 1, 2, 3, 3 });

            _ = kthLargest.Add(3).Should().Be(3);
            _ = kthLargest.Add(5).Should().Be(3);
            _ = kthLargest.Add(6).Should().Be(3);
            _ = kthLargest.Add(7).Should().Be(5);
            _ = kthLargest.Add(8).Should().Be(6);
        }
    }
}