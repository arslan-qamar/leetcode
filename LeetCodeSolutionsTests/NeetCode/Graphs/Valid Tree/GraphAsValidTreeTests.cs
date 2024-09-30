using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Valid_Tree;

namespace Valid_Tree.Tests
{
    [TestClass()]
    public class GraphAsValidTreeTests
    {
        [TestMethod()]
        public void ValidTreeTest()
        {
            GraphAsValidTree g = new GraphAsValidTree();


            g.ValidTree(5, [[0, 1], [0, 2], [0, 3], [1, 4]]).Should().BeTrue();
            
        }

        [TestMethod()]
        public void InValidTreeTest()
        {
            GraphAsValidTree g = new GraphAsValidTree();


            g.ValidTree(5, [[0, 1], [1, 2], [2, 3], [1, 3], [1, 4]]).Should().BeFalse();

        }
    }
}