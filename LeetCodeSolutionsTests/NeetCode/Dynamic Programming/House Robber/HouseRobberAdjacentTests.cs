using FluentAssertions;
using LeetCodeSolutions.NeetCode.Dynamic_Programming.House_Robber;

namespace House_Robber.Tests
{
    [TestClass()]
    public class HouseRobberAdjacentTests
    {
        [TestMethod()]
        public void RobTest()
        {
            HouseRobberAdjacent hra = new HouseRobberAdjacent();
            hra.Rob([1, 1, 3, 3]).Should().Be(4);
        }
    }
}