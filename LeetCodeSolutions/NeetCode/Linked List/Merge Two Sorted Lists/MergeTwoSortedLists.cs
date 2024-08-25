namespace Merge_Two_Sorted_Lists
{
    public class ListNode
    {
        public readonly int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null && list2 == null)
            {
                return null;
            }

            ListNode result = new ListNode(0, null);

            ListNode temp = result;

            while (list1 != null || list2 != null)
            {
                if (list1 == null || list2 == null)
                {
                    if (list1 != null)
                    {
                        temp.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        temp.next = list2;
                        list2 = list2.next;
                    }
                }
                else
                {
                    if (list1.val <= list2.val)
                    {
                        temp.next = list1;
                        list1 = list1.next;
                    }
                    else
                    {
                        temp.next = list2;
                        list2 = list2.next;
                    }
                }

                temp = temp.next;
            }

            return result.next;
        }
    }
}
