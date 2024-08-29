using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Level_Order_Traversal.Level_Order_Traversal;

namespace Level_Order_Traversal.Tests
{
    [TestClass()]
    public class Level_Order_TraversalTests
    {
        [TestMethod()]
        public void LevelOrderTest()
        {
            Level_Order_Traversal levelOrderTraversal = new Level_Order_Traversal();


            levelOrderTraversal.LevelOrder(

                new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7)))
                ).Should().BeEquivalentTo(
                new List<List<int>>()
                {
                    new List<int>() {1 },
                    new List<int>() { 2,3},
                    new List<int>() { 4,5,6,7}
                }

                );
        }
    }
}