namespace Add_Two_Numbers
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


    public class LinkedListAddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode currL1 = l1;
            ListNode currL2 = l2;

            ListNode dummy = new ListNode(0, null);
            ListNode result = dummy;

            int carry = 0;
            int sum;
            while (currL1 != null && currL2 != null)
            {

                sum = carry + currL1.val + currL2.val;

                carry = sum / 10;

                sum = sum % 10;

                result.next = new ListNode(sum, null);
                result = result.next;

                currL1 = currL1.next;
                currL2 = currL2.next;
            }

            while (currL1 != null)
            {
                sum = carry + currL1.val;

                carry = sum / 10;

                sum = sum % 10;

                result.next = new ListNode(sum, null);
                result = result.next;

                currL1 = currL1.next;

            }

            while (currL2 != null)
            {
                sum = carry + currL2.val;

                carry = sum / 10;

                sum = sum % 10;

                result.next = new ListNode(sum, null);
                result = result.next;

                currL2 = currL2.next;
            }

            if (carry > 0)
            {
                result.next = new ListNode(carry, null);
            }

            return dummy.next;
        }
    }
}
