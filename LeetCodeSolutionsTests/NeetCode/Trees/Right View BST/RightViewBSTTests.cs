using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;

namespace Right_View_BST.Tests
{
    [TestClass()]
    public class RightViewBSTTests
    {
        [TestMethod()]
        public void RightSideViewTest()
        {
            _ = RightViewBST.RightSideView(
                new TreeNode(1, new TreeNode(2), new TreeNode(3)))
                .Should().BeEquivalentTo(new List<int>() { 1, 3 });
        }

        [TestMethod()]
        public void RightSideViewTest2()
        {
            _ = RightViewBST.RightSideView(
                new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7))))
                .Should().BeEquivalentTo(new List<int>() { 1, 3, 7 });
        }
    }
}