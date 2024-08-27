namespace Reverse_Nodes_in_K_Groups
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

    public class ReverseNodesKGroup
    {


        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            int currK = k - 1;

            ListNode left = head;
            ListNode right = head;
            ListNode previousListEnd = new ListNode(0, left);

            while (right != null)
            {
                right = right.next;
                currK--;

                if (currK == 0 && right != null)
                {
                    if (head == left)
                    {
                        // This is executed on first sorted list only
                        head = right;
                    }

                    ListNode nextListStart = right.next;

                    ReverseList(left, nextListStart);

                    previousListEnd.next = right;
                    previousListEnd = left;
                    left = right = nextListStart;
                    currK = k - 1;
                }
            }

            if (previousListEnd != null)
            {
                previousListEnd.next = left;
            }

            return head;
        }

        public static ListNode ReverseList(ListNode head, ListNode nextListStart)
        {
            ListNode curr = head;
            ListNode? prev = null;

            while (curr != nextListStart)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }

    }
}
