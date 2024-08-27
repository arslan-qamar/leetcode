using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Reorder_List.Tests
{
    [TestClass()]
    public class ReorderListHandlerTests
    {
        [TestMethod()]
        public void ReorderListTest()
        {
            ListNode listNode = new ListNode(2, new ListNode(4, new ListNode(6, new ListNode(8, null))));
            ReorderListHandler.ReorderList(listNode);

            listNode.ShouldBeEquivalentTo(new ListNode(2, new ListNode(8, new ListNode(4, new ListNode(6, null)))));
        }

        [TestMethod()]
        public void ReorderListTest2()
        {
            ListNode listNode = new ListNode(2, new ListNode(4, new ListNode(6, null)));
            ReorderListHandler.ReorderList(listNode);

            listNode.ShouldBeEquivalentTo(new ListNode(2, new ListNode(6, new ListNode(4, null))));
        }


        [TestMethod()]
        public void ReorderListTest3()
        {
            ListNode listNode = new ListNode(2, new ListNode(4, new ListNode(6, new ListNode(8, new ListNode(10, new ListNode(12, null))))));
            ReorderListHandler.ReorderList(listNode);

            listNode.ShouldBeEquivalentTo(new ListNode(2, new ListNode(12, new ListNode(4, new ListNode(10, new ListNode(6, new ListNode(8, null)))))));
        }
    }
}