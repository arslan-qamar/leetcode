using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Balanced_BST_Checker.Tests
{
    [TestClass()]
    public class BSTBalanceCheckerTests
    {
        [TestMethod()]
        public void IsBalancedTest()
        {
            BSTBalanceChecker.IsBalanced(
                new TreeNode(1, new TreeNode(2), new TreeNode(3, new TreeNode(4)))
                ).Should().BeTrue();
        }
    }
}