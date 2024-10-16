using FluentAssertions;
using LeetCodeSolutions.NeetCode.Dynamic_Programming.House_Robber_II;

namespace House_Robber_II.Tests
{
    [TestClass()]
    public class HouseRobberTests
    {
        [TestMethod()]
        public void RobTest()
        {
            HouseRobber hr = new HouseRobber();

            hr.Rob([3, 4, 3]).Should().Be(4);
        }
    }
}