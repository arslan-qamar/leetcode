using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using LeetCodeSolutions.NeetCode.Trees.ValidBST;

namespace ValidBSTTests
{
    [TestClass()]
    public class ValidBSTTests
    {
        [TestMethod()]
        public void IsValidBSTTest()
        {
            ValidBST.IsValidBST(new TreeNode(2, new TreeNode(1), new TreeNode(3))).Should().BeTrue();
        }

        [TestMethod()]
        public void IsInValidBSTTest()
        {
            ValidBST.IsValidBST(new TreeNode(1, new TreeNode(2), new TreeNode(3))).Should().BeFalse();
        }


        [TestMethod()]
        public void IsInValidBSTTest2()
        {
            ValidBST.IsValidBST(new TreeNode(4, new TreeNode(3, new TreeNode(2, null, new TreeNode(4))))).Should().BeFalse();
        }

    }
}