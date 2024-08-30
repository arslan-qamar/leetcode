using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvertBST
{
    [TestClass()]
    public class InvertBinarySearchTreeTests
    {
        [TestMethod()]
        public void InvertTreeTest()
        {
            InvertBinarySearchTree.InvertTree(
                new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7)))
                ).Should().BeEquivalentTo(
                new TreeNode(1, new TreeNode(3, new TreeNode(7), new TreeNode(6)), new TreeNode(2, new TreeNode(5), new TreeNode(4)))               
                );

        }
    }
}