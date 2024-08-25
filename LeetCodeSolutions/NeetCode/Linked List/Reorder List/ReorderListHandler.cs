namespace LeetCodeSolutions.NeetCode.Linked_List.Reorder_List
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

    public class ReorderListHandler
    {
        public static void ReorderList(ListNode head)
        {

            ListNode slowPtr = head;
            ListNode fastPtr = head.next;


            while (fastPtr?.next != null)
            {
                slowPtr = slowPtr.next;
                fastPtr = fastPtr.next.next;

            }

            // Reverse the Right half of the list            

            ListNode curr = slowPtr.next;
            ListNode previous = slowPtr.next = null;

            while (curr != null)
            {
                ListNode temp = curr.next;
                curr.next = previous;
                previous = curr;
                curr = temp;
            }

            ListNode leftListStart = head;
            ListNode rightListStart = previous;

            while (rightListStart != null)
            {

                ListNode ltemp = leftListStart.next;
                ListNode rtemp = rightListStart.next;

                leftListStart.next = rightListStart;
                rightListStart.next = ltemp;

                leftListStart = ltemp;
                rightListStart = rtemp;
            }
        }
    }
}
