namespace LeetCodeSolutions.NeetCode.Linked_List.LRU_Cache
{
    public class LRUCache
    {
        public class ListNode
        {
            public readonly int key;
            public readonly int val;
            public ListNode next;
            public ListNode previous;

            public ListNode(int key = 0, int val = 0, ListNode next = null, ListNode previous = null)
            {
                this.key = key;
                this.val = val;
                this.next = next;
                this.previous = previous;
            }
        }


        private readonly int capacity;
        private readonly Dictionary<int, ListNode> cache = new Dictionary<int, ListNode>();

        private readonly ListNode head;
        private readonly ListNode tail;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;

            this.head = new ListNode(int.MinValue);
            this.tail = new ListNode(int.MaxValue);

            this.head.next = this.tail;
            this.tail.previous = this.head;
        }

        public int Get(int key)
        {
            cache.TryGetValue(key, out ListNode? val);

            if (cache.ContainsKey(key))
            {
                RemoveNode(val);
                AddNode(val);
            }

            return val?.val ?? -1;
        }

        private void RemoveNode(ListNode? val)
        {
            val.previous.next = val.next;
            val.next.previous = val.previous;
        }

        private void AddNode(ListNode? val)
        {
            val.next = tail;
            val.previous = tail.previous;

            tail.previous.next = val;
            tail.previous = val;
        }

        public void Put(int key, int value)
        {
            ListNode newValue = new ListNode(key, value);

            if (cache.ContainsKey(key))
            {
                cache.TryGetValue(key, out ListNode? val);
                RemoveNode(val);
            }

            AddNode(newValue);
            cache[key] = newValue;

            if (cache.Count > capacity)
            {
                cache.Remove(head.next.key);
                RemoveNode(head.next);
            }
        }
    }
}
