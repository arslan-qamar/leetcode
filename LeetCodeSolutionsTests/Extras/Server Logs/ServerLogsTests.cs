using FluentAssertions;

namespace Extras.Test_1.Tests
{
    [TestClass()]
    public class ServerLogsTests
    {

        [TestMethod()]
        public void getStaleServerCountTest()
        {
            _ = ServerLogs.getStaleServerCount(3,
                [
                    [3,3],
                    [2,6],
                    [1,5],

                ],
                [10, 11],
                5).Should().BeEquivalentTo(new List<int>() { 1, 2 });
        }

        [TestMethod()]
        public void getStaleServerCountTest0()
        {
            _ = ServerLogs.getStaleServerCount(6,
                [
                    [3,2],
                    [4,3],
                    [2,6],
                    [6,3]
                ],
                [3, 2, 6],
                2).Should().BeEquivalentTo(new List<int>() { 3, 5, 5 });
        }


        [TestMethod()]
        public void getStaleServerCountTest2()
        {
            _ = ServerLogs.getStaleServerCount(4,
                [
                    [1,3],
                    [2,6],
                    [1,5],
                    [3,4]

                ],
                [10, 6],
                5).Should().BeEquivalentTo(new List<int>() { 2, 1 });
        }


        [TestMethod()]
        public void getStaleServerCountTest3()
        {
            _ = ServerLogs.getStaleServerCount(6,
                [
                    [3,2],
                    [4,3],
                    [2,6],
                    [6,3]

                ],
                [3, 2, 6],
                2).Should().BeEquivalentTo(new List<int>() { 3, 5, 5 });
        }
    }
}