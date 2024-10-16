using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Redundant_Connection;

namespace Redundant_Connection.Tests
{
    [TestClass()]
    public class RedundantConnectionTests
    {
        [TestMethod()]
        public void FindRedundantConnectionTest()
        {
            RedundantConnection rc = new RedundantConnection();

            rc.FindRedundantConnection([[1, 2], [1, 3], [3, 4], [2, 4]]).Should().BeEquivalentTo(new int[] { 2, 4 });
        }

        [TestMethod()]
        public void FindRedundantConnectionTest2()
        {
            RedundantConnection rc = new RedundantConnection();

            rc.FindRedundantConnection([[1, 2], [1, 3], [1, 4], [3, 4], [4, 5]]).Should().BeEquivalentTo(new int[] { 3, 4 });
        }
    }
}