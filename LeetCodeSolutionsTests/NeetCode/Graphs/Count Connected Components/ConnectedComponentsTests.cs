using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Graphs.Count_Connected_Components.Tests
{
    [TestClass()]
    public class ConnectedComponentsTests
    {
        [TestMethod()]
        public void CountComponentsTest()
        {
            ConnectedComponents c = new ConnectedComponents();
            c.CountComponents(3, [[0, 1], [0, 2]]).Should().Be(1);
        }

        [TestMethod()]
        public void CountComponentsTest2()
        {
            ConnectedComponents c = new ConnectedComponents();
            c.CountComponents(6, [[0, 1], [1, 2], [2, 3], [4, 5]]).Should().Be(2);
        }

        [TestMethod()]
        public void CountComponentsTestNeetcodeFailed()
        {
            ConnectedComponents c = new ConnectedComponents();
            c.CountComponents(1, []).Should().Be(1);
        }
    }
}