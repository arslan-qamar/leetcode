using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;

namespace Balanced_BST_Checker.Tests
{
    [TestClass()]
    public class BSTBalanceCheckerTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            _ = BSTBalanceChecker.IsBalanced(
                new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4)))
                ).Should().BeTrue();
        }
    }
}