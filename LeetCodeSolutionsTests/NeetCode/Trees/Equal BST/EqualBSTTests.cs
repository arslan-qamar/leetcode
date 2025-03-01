﻿using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;

namespace Equal_BST.Tests
{
    [TestClass()]
    public class EqualBSTTests
    {
        [TestMethod()]
        public void IsSameTreeTest()
        {
            _ = EqualBST.IsSameTree(
                new TreeNode(1, new TreeNode(2), new TreeNode(3)),
                new TreeNode(1, new TreeNode(2), new TreeNode(3))
                ).Should().BeTrue();

        }

        [TestMethod()]
        public void IsSameTreeTest2()
        {
            _ = EqualBST.IsSameTree(
                new TreeNode(4, new TreeNode(7)),
                new TreeNode(4, null, new TreeNode(7))
                ).Should().BeFalse();


        }
    }
}