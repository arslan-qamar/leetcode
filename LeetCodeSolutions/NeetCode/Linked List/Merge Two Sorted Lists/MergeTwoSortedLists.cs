namespace Merge_Two_Sorted_Lists
{
    public class ListNode
    {
        public readonly int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeTwoSortedLists
    {
        public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {

            if (list1 == null && list2 == null)
            {
                return null;
            }

            ListNode dummy = new ListNode(0);
            ListNode curr = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    curr.next = list1;
                    curr = list1;
                    list1 = list1.next;
                }
                else
                {
                    curr.next = list2;
                    curr = list2;
                    list2 = list2.next;
                }
            }

            curr.next = list1 ?? list2;

            return dummy.next;
        }
    }
}
