using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Balanced_BST_Checker.BSTBalanceChecker;

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