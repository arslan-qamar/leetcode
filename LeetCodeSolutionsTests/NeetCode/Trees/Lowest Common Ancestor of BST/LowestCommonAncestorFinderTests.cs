using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Lowest_Common_Ancestor_of_BST.LowestCommonAncestorFinder;

namespace Lowest_Common_Ancestor_of_BST.Tests
{
    [TestClass()]
    public class LowestCommonAncestorFinderTests
    {
        [TestMethod()]
        public void LowestCommonAncestorTest()
        {
            var lcaFinder = new LowestCommonAncestorFinder();


            lcaFinder.LowestCommonAncestor(
                new TreeNode(5, new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), new TreeNode(8, new TreeNode(7), new TreeNode(9))),
                new TreeNode(3),
                new TreeNode(4)
                ).Should().BeEquivalentTo(new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)));
        }

        [TestMethod()]
        public void LowestCommonAncestorTest2()
        {
            var lcaFinder = new LowestCommonAncestorFinder();


            lcaFinder.LowestCommonAncestor(
                new TreeNode(5, new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), new TreeNode(8, new TreeNode(7), new TreeNode(9))),
                new TreeNode(3),
                new TreeNode(8)
                ).Should().BeEquivalentTo(new TreeNode(5, new TreeNode(3, new TreeNode(1, null, new TreeNode(2)), new TreeNode(4)), new TreeNode(8, new TreeNode(7), new TreeNode(9))));
        }

    }
}