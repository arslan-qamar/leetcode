using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;

namespace Binary_Tree_from_Pre_In_Order.Tests
{
    [TestClass()]
    public class BinaryPreInOrderCreateTests
    {
        [TestMethod()]
        public void BuildTreeTest()
        {
            _ = BinaryPreInOrderCreate.BuildTree(new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 3, 4 }).Should().BeEquivalentTo(
                new TreeNode(1, new TreeNode(2), new TreeNode(3, null, new TreeNode(4)))
                );
        }
    }
}