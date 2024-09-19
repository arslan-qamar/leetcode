using FluentAssertions;
using static Merge_K_Sorted_Lists.MergeKSortedLists;

namespace Merge_K_Sorted_Lists.Tests
{
    [TestClass()]
    public class MergeKSortedListsTests
    {
        [TestMethod()]
        public void MergeKListsTest()
        {
            _ = MergeKSortedLists.MergeKLists(
                new ListNode[]
                {
                    new(1, new ListNode(2, new ListNode(4))),
                    new(1, new ListNode(3, new ListNode(5))),
                    new(3, new ListNode(6))
                }
                ).Should().BeEquivalentTo(

                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))))))

                );
        }
    }
}