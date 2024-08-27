using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reverse_Nodes_in_K_Groups.Tests
{
    [TestClass()]
    public class ReverseNodesKGroupTests
    {
        [TestMethod()]
        public void ReverseKGroupTest()
        {
            ReverseNodesKGroup.ReverseKGroup(
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8, new ListNode(9))))))))), 3
                )
                .Should().BeEquivalentTo(
                new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(6, new ListNode(5, new ListNode(4, new ListNode(9, new ListNode(8, new ListNode(7)))))))))
                );
        }

        [TestMethod()]
        public void ReverseKGroupTest2()
        {
            ReverseNodesKGroup.ReverseKGroup(
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8)))))))), 3
                )
                .Should().BeEquivalentTo(
                new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(6, new ListNode(5, new ListNode(4, new ListNode(7, new ListNode(8))))))))
                );
        }


        [TestMethod()]
        public void ReverseKGroupTest3()
        {
            ReverseNodesKGroup.ReverseKGroup(
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8)))))))), 1
                )
                .Should().BeEquivalentTo(
                new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6, new ListNode(7, new ListNode(8))))))))
                );
        }

    }
}