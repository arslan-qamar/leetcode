namespace Heaps_And_Priority_Queue
{
    public class KthLargest
    {
        private readonly int k;
        private readonly int[] nums;
        PriorityQueue<int, int> minHeap;

        public KthLargest(int k, int[] nums)
        {
            this.k = k;
            this.nums = nums;
            minHeap = new PriorityQueue<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                minHeap.Enqueue(nums[i], nums[i]);
                if (minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }
        }

        public int Add(int val)
        {
            minHeap.Enqueue(val, val);

            if (minHeap.Count > k)
            {
                minHeap.Dequeue();
            }

            return minHeap.Peek();
        }

    }
}
