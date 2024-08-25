using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeSolutions.NeetCode.Linked_List.Remove_Node_From_End.Tests
{
    [TestClass()]
    public class RemoveNodeFromEndTests
    {
        [TestMethod()]
        public void RemoveNthFromEndTest()
        {
            RemoveNodeFromEnd.RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, null)))), 2)
                .Should().BeEquivalentTo(new ListNode(1, new ListNode(2, new ListNode(4, null))));
        }

        [TestMethod()]
        public void RemoveNthFromEndTest2()
        {
            RemoveNodeFromEnd.RemoveNthFromEnd(new ListNode(5, null), 1)
                .Should().BeNull();
        }

    }
}