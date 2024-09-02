using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Binary_Tree_Maximum_Path_Sum.Tests
{
    [TestClass()]
    public class MaxPathSumFinderTests
    {
        [TestMethod()]
        public void MaxPathSumTest()
        {
            MaxPathSumFinder.MaxPathSum(
                new TreeNode(1, new TreeNode(2), new TreeNode(3))).Should().Be(6);                        
        }
    }
}