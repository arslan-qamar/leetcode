using FluentAssertions;

namespace Advance_Graphs.ConnectAllPoints.Tests
{
    [TestClass()]
    public class ConnectAllPointsTests
    {
        [TestMethod()]
        public void MinCostConnectPointsTest()
        {
            ConnectAllPoints c = new ConnectAllPoints();
            c.MinCostConnectPoints([[0, 0], [2, 2], [3, 3], [2, 4], [4, 2]]).Should().Be(10);
        }

        [TestMethod()]
        public void MinCostConnectPointsTestNCFail()
        {
            ConnectAllPoints c = new ConnectAllPoints();
            c.MinCostConnectPoints([[0, 0], [1, 1], [1, 0], [-1, 1]]).Should().Be(4);
        }
    }
}