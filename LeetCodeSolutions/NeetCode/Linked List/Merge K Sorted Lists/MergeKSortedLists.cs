namespace LeetCodeSolutions.NeetCode.Linked_List.Merge_K_Sorted_Lists
{
    public class MergeKSortedLists
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

        public static ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0)
            {
                return null;
            }

            if (lists.Length == 1)
            {
                return lists[0];
            }

            List<ListNode> mergedList = new List<ListNode>();

            while (lists.Length > 1)
            {
                mergedList.Clear();
                for (int i = 0; i < lists.Length; i = i + 2)
                {
                    ListNode l1 = lists[i];
                    ListNode? l2 = i + 1 < lists.Length ? lists[i + 1] : null;

                    mergedList.Add(MergeTwoLists(l1, l2));
                }

                lists = mergedList.ToArray();
            }

            return lists.First();
        }

        private static ListNode MergeTwoLists(ListNode l1, ListNode? l2)
        {
            ListNode dummy = new ListNode(0, l1);
            ListNode curr = dummy;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    curr.next = l1;
                    curr = l1;
                    l1 = l1.next;
                }
                else
                {
                    curr.next = l2;
                    curr = l2;
                    l2 = l2.next;
                }
            }

            curr.next = l1 ?? l2;

            return dummy.next;
        }
    }
}
