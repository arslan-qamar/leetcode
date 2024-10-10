using FluentAssertions;
using LeetCodeSolutions.NeetCode.Dynamic_Programming.Stairs_Climbing_Cost;

namespace Stairs_Climbing_Cost.Tests
{
    [TestClass()]
    public class StairsCostTests
    {
        [TestMethod()]
        public void MinCostClimbingStairsDFSTest()
        {
            StairsCost sc = new StairsCost();
            sc.MinCostClimbingStairsDFS([1, 2, 3]).Should().Be(2);
        }

        [TestMethod()]
        public void MinCostClimbingStairsTest()
        {
            StairsCost sc = new StairsCost();
            sc.MinCostClimbingStairs([1, 2, 3]).Should().Be(2);
        }
    }
}