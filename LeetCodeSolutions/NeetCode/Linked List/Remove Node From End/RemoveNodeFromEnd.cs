namespace Remove_Node_From_End
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

    public class RemoveNodeFromEnd
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode left = dummy;
            ListNode right = head;


            while (n > 0)
            {
                right = right.next;
                n--;
            }


            while (right != null)
            {
                left = left.next;
                right = right.next;
            }

            left.next = left.next.next;
            return dummy.next;
        }
    }
}
