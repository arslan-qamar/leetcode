using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kth_Smallest_Element_BST.Tests
{
    [TestClass()]
    public class KthItemFinderTests
    {
        [TestMethod()]
        public void KthSmallestTest()
        {
            KthItemFinder.KthSmallest(
                new TreeNode(
                2, new TreeNode(1), new TreeNode(3)), 1).Should().Be(1);
        }
    }
}