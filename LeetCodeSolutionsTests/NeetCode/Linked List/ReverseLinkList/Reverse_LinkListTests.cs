using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Linked_List.Tests
{
    [TestClass()]
    public class Reverse_LinkListTests
    {
        [TestMethod()]
        public void ReverseListTest()
        {
            Reverse_LinkList.ReverseList(null).Should().Be(null);
        }

        [TestMethod()]
        public void ReverseListTest1()
        {
            Reverse_LinkList.ReverseList(new ListNode(1, null)).Should().BeEquivalentTo(new ListNode(1, null));
        }

        [TestMethod()]
        public void ReverseListTest2()
        {
            Reverse_LinkList.ReverseList(new ListNode(1, new ListNode(2, null)))
                .Should().BeEquivalentTo(new ListNode(2, new ListNode(1, null)), options => options.WithStrictOrdering());
        }

        [TestMethod()]
        public void ReverseListTest3()
        {
            Reverse_LinkList.ReverseList(new ListNode(1, new ListNode(2, new ListNode(3, null))))
                .Should().BeEquivalentTo(new ListNode(3, new ListNode(2, new ListNode(1, null))), options => options.WithStrictOrdering());
        }

    }
}