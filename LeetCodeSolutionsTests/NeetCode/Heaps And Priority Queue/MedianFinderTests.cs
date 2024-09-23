using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Heaps_And_Priority_Queue.Tests
{
    [TestClass()]
    public class MedianFinderTests
    {
        [TestMethod()]
        public void FindMedianTest()
        {
            MedianFinder m = new MedianFinder();

            m.AddNum(1);
            m.AddNum(2);
            m.FindMedian().Should().Be(1.5);
            m.AddNum(3);

            m.FindMedian().Should().Be(2.0);

            m.AddNum(4);
            m.AddNum(3);
            m.FindMedian().Should().Be(3);
            
        }
    }
}
