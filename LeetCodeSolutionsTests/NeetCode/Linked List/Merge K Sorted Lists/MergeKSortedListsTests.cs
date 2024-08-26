using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static LeetCodeSolutions.NeetCode.Linked_List.Merge_K_Sorted_Lists.MergeKSortedLists;

namespace LeetCodeSolutions.NeetCode.Linked_List.Merge_K_Sorted_Lists.Tests
{
    [TestClass()]
    public class MergeKSortedListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            MergeKSortedLists.MergeKLists(
                new ListNode[]
                {
                    new ListNode(1, new ListNode(2, new ListNode(4))),
                    new ListNode(1, new ListNode(3, new ListNode(5))),
                    new ListNode(3, new ListNode(6))
                }
                ).Should().BeEquivalentTo(

                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))))))

                );
        }
    }
}