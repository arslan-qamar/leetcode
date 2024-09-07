namespace Task_Scheduler
{
    public class TaskScheduler
    {
        public static int LeastInterval(char[] tasks, int n)
        {
            int result = 0;

            int[] freq = new int[26];

            for (int i = 0; i < tasks.Length; i++)
            {
                freq[tasks[i] - 'A'] = ++freq[tasks[i] - 'A'];
            }

            PriorityQueue<int, int> maxPriority = new PriorityQueue<int, int>();
            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    maxPriority.Enqueue(freq[i], -freq[i]);
                }
            }
            
            while (maxPriority.Count > 0)
            {

                List<int> topFreq = new List<int>();
                for (int i = 1; i <= n+1; i++)
                {
                    if (maxPriority.Count == 0)
                    { break; }

                    topFreq.Add(maxPriority.Dequeue() - 1);
                }                

                for (int i = 0; i < topFreq.Count; i++)
                {
                    if (topFreq[i] > 0)
                    {
                        maxPriority.Enqueue(topFreq[i], -topFreq[i]);
                    }
                }

                if(maxPriority.Count > 0)
                {
                    result = result + n + 1;
                }
                else
                {
                    result = result + topFreq.Count;
                }

            }

            return result;
        }
    }
}
