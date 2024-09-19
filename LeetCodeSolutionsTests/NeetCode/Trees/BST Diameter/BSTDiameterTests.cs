using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;

namespace BST_Diameter.Tests
{
    [TestClass()]
    public class BSTDiameterTests
    {
        [TestMethod()]
        public void DiameterOfBinaryTreeTest()
        {
            _ = BSTDiameter.DiameterOfBinaryTree(
                new TreeNode(1, null, new TreeNode(2, new TreeNode(3, new TreeNode(5)), new TreeNode(4)))
                ).Should().Be(3);
        }
    }
}