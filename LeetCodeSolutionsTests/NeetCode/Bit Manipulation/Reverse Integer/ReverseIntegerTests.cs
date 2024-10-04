using FluentAssertions;

namespace Reverse_Integer.Tests
{
    [TestClass()]
    public class ReverseIntegerTests
    {
        [TestMethod()]
        public void ReverseTest()
        {
            ReverseInteger ri = new ReverseInteger();
            ri.Reverse(123456).Should().Be(654321);
        }

        [TestMethod()]
        public void ReverseTestNC1()
        {
            ReverseInteger ri = new ReverseInteger();
            ri.Reverse(-1234).Should().Be(-4321);
        }

        [TestMethod()]
        public void ReverseTestNC2()
        {
            ReverseInteger ri = new ReverseInteger();
            ri.Reverse(1234236467).Should().Be(0);
        }

    }
}