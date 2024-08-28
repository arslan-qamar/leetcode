using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace SubTree_Checker.Tests
{
    [TestClass()]
    public class SubTreeCheckerTests
    {
        [TestMethod()]
        public void IsSubtreeTest()
        {

            SubTreeChecker subTreeChecker = new SubTreeChecker();
            subTreeChecker.IsSubtree(new TreeNode(1), new TreeNode(1)).Should().BeTrue();


        }

    }
}