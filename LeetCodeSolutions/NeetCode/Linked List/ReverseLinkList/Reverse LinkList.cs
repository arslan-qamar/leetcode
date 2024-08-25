namespace Linked_List
{
    public class ListNode
    {
        public readonly int val;
        public ListNode next;

        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Reverse_LinkList
    {
        public static ListNode ReverseList(ListNode head)
        {
            ListNode previous = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            return previous;
        }

    }

}
