﻿using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;

namespace SubTree_Checker.Tests
{
    [TestClass()]
    public class SubTreeCheckerTests
    {
        [TestMethod()]
        public void IsSubtreeTest()
        {

            SubTreeChecker subTreeChecker = new();
            _ = subTreeChecker.IsSubtree(new TreeNode(1), new TreeNode(1)).Should().BeTrue();


        }

    }
}