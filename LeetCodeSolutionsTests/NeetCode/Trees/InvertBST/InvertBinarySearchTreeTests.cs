using FluentAssertions;
using InvertBST;
using LeetCodeSolutions.NeetCode.Trees;

namespace InvertBSTTests
{
    [TestClass()]
    public class InvertBinarySearchTreeTests
    {
        [TestMethod()]
        public void InvertTreeTest()
        {
            _ = InvertBinarySearchTree.InvertTree(
                new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7)))
                ).Should().BeEquivalentTo(
                new TreeNode(1, new TreeNode(3, new TreeNode(7), new TreeNode(6)), new TreeNode(2, new TreeNode(5), new TreeNode(4)))
                );

        }
    }
}