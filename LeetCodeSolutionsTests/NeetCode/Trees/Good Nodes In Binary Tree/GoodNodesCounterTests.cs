using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Good_Nodes_In_Binary_Tree.Tests
{
    [TestClass()]
    public class GoodNodesCounterTests
    {
        [TestMethod()]
        public void GoodNodesTest()
        {
            GoodNodesCounter.GoodNodes(
                new TreeNode(2, new TreeNode(1, new TreeNode(3)), new TreeNode(1, new TreeNode(1), new TreeNode(5)))
                ).Should().Be(3);
        }

        [TestMethod()]
        public void GoodNodesTest2()
        {
            GoodNodesCounter.GoodNodes(
                new TreeNode(1, new TreeNode(2, new TreeNode(3), new TreeNode(4)), new TreeNode(-1))
                ).Should().Be(4);
        }
    }
}