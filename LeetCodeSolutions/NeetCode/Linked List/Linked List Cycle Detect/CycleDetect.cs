namespace LeetCodeSolutions.NeetCode.Linked_List.Linked_List_Cycle_Detect
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
    public class CycleDetect
    {
        public static bool HasCycle(ListNode head)
        {
            ListNode currSlow = head;
            ListNode currFast = head.next;
            while (currSlow != null && currFast != null && currSlow != currFast)
            {
                currSlow = currSlow.next;
                currFast = currFast.next?.next;
            }

            return currFast == currSlow;
        }
    }
}
