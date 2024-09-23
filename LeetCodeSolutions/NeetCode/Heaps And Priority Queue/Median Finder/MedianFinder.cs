namespace LeetCodeSolutions.NeetCode.Heaps_And_Priority_Queue
{
    public class MedianFinder
    {

        PriorityQueue<int, int> maxHeap;
        PriorityQueue<int, int> minHeap;

        public MedianFinder()
        {
            maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            minHeap = new PriorityQueue<int, int>();
        }

        public void AddNum(int num)
        {
            if (minHeap.Count > 0 && num > minHeap.Peek())
            {
                minHeap.Enqueue(num, num);
            }
            else
            {
                maxHeap.Enqueue(num, num);
            }

            while (maxHeap.Count > minHeap.Count + 1)
            {
                int el = maxHeap.Dequeue();
                minHeap.Enqueue(el, el);
            }

            while (minHeap.Count > maxHeap.Count + 1)
            {
                int el = minHeap.Dequeue();
                maxHeap.Enqueue(el, el);
            }

        }

        public double FindMedian()
        {
            if((minHeap.Count + maxHeap.Count) % 2 == 0)
            {
                return (minHeap.Peek() + maxHeap.Peek()) / 2.0;
            }
            else if(minHeap.Count > maxHeap.Count)
            {
                return minHeap.Peek();
            }
            else
            {
                return maxHeap.Peek();
            }
        }
    }
}
