using FluentAssertions;

namespace Merge_Two_Sorted_Lists.Tests
{
    [TestClass()]
    public class MergeTwoSortedListsTests
    {
        [TestMethod()]
        public void MergeTwoListsTest()
        {
            ListNode list1 = new(1, new ListNode(2, new ListNode(4)));
            ListNode list2 = new(1, new ListNode(3, new ListNode(5)));

            _ = MergeTwoSortedLists.MergeTwoLists(list1, list2).Should().BeEquivalentTo(
                new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))))
                );
        }


        [TestMethod()]
        public void MergeTwoListsTest2()
        {
            ListNode list1 = new(1);
            ListNode list2 = new(1, new ListNode(3, new ListNode(5)));

            _ = MergeTwoSortedLists.MergeTwoLists(list1, list2).Should().BeEquivalentTo(
                new ListNode(1, new ListNode(1, new ListNode(3, new ListNode(5))))
                );
        }

        [TestMethod()]
        public void MergeTwoListsTest3()
        {
            ListNode? list1 = null;
            ListNode list2 = new(1, new ListNode(3, new ListNode(5)));

            _ = MergeTwoSortedLists.MergeTwoLists(list1, list2).Should().BeEquivalentTo(
                new ListNode(1, new ListNode(3, new ListNode(5)))
                );
        }

    }
}