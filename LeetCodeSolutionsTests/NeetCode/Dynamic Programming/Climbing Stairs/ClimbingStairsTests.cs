using FluentAssertions;
using LeetCodeSolutions.NeetCode.Dynamic_Programming;

namespace ClimbingStairsTests
{
    [TestClass()]
    public class ClimbingStairsTests
    {
        [TestMethod()]
        public void ClimbStairsTest()
        {
            ClimbingStairs cs = new ClimbingStairs();
            cs.ClimbStairs(2).Should().Be(2);
        }

        [TestMethod()]
        public void ClimbStairsTest2()
        {
            ClimbingStairs cs = new ClimbingStairs();
            cs.ClimbStairs(3).Should().Be(3);
        }

        [TestMethod()]
        public void ClimbStairsTestnc1()
        {
            ClimbingStairs cs = new ClimbingStairs();
            cs.ClimbStairs(1).Should().Be(1);
        }
    }
}