using FluentAssertions;
using LeetCodeSolutions.NeetCode.Advance_Graphs.Network_Delay;

namespace Network_Delay.Tests
{
    [TestClass()]
    public class NetworkDelayTests
    {
        [TestMethod()]
        public void NetworkDelayTimeTest()
        {
            NetworkDelay nd = new NetworkDelay();
            nd.NetworkDelayTime([[1, 2, 1], [2, 3, 1], [1, 4, 4], [3, 4, 1]], 4, 1).Should().Be(3);
        }

        [TestMethod()]
        public void NetworkDelayTimeTest2()
        {
            NetworkDelay nd = new NetworkDelay();
            nd.NetworkDelayTime([[1, 2, 1], [2, 3, 1]], 3, 2).Should().Be(-1);
        }


        [TestMethod()]
        public void NetworkDelayTimeTestNCFail()
        {
            NetworkDelay nd = new NetworkDelay();
            nd.NetworkDelayTime([[2, 1, 1], [2, 3, 1], [3, 4, 1]], 4, 2).Should().Be(2);
        }


        [TestMethod()]
        public void NetworkDelayTimeTestNCFail2()
        {
            NetworkDelay nd = new NetworkDelay();
            nd.NetworkDelayTime([[1, 2, 1], [2, 1, 3]], 2, 2).Should().Be(3);
        }

        [TestMethod()]
        public void NetworkDelayTimeTestNCFail3()
        {
            NetworkDelay nd = new NetworkDelay();
            nd.NetworkDelayTime([[2, 4, 10], [5, 2, 38], [3, 4, 33], [4, 2, 76], [3, 2, 64], [1, 5, 54], [1, 4, 98], [2, 3, 61], [2, 1, 0], [3, 5, 77], [5, 1, 34], [3, 1, 79], [5, 3, 2], [1, 2, 59], [4, 3, 46], [5, 4, 44], [2, 5, 89], [4, 5, 21], [1, 3, 86], [4, 1, 95]], 5, 1).Should().Be(69);
        }


    }
}