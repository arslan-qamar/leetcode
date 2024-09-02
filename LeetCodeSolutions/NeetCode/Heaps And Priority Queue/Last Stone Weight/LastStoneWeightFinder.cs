namespace Last_Stone_Weight
{
    public class LastStoneWeightFinder
    {
        public static int LastStoneWeight(int[] stones)
        {
            if (stones == null || stones.Length == 0)
                return 0;

            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();

            for (int i = 0; i < stones.Length; i++)
            {
                maxHeap.Enqueue(stones[i], -stones[i]);
            }

            while(maxHeap.Count > 1)
            {
                int firstStone = maxHeap.Dequeue();
                int secondStone = maxHeap.Dequeue();

                int remainingStone = firstStone - secondStone;
                maxHeap.Enqueue(remainingStone, -remainingStone);
                
            }

            return maxHeap.Peek();
        }
    }
}
