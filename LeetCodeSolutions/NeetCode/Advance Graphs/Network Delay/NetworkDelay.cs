namespace LeetCodeSolutions.NeetCode.Advance_Graphs.Network_Delay
{
    public class NetworkDelay
    {
        public int NetworkDelayTime(int[][] times, int n, int k)
        {
            int minTime = 0;

            Dictionary<int, List<(int Time, int Node)>> adjList = new Dictionary<int, List<(int Time, int Node)>>();

            foreach (var item in times)
            {
                int source = item[0];
                int dest = item[1];
                int time = item[2];

                if (!adjList.ContainsKey(source))
                {
                    adjList[source] = new List<(int Time, int Node)>();
                }
                adjList[source].Add((time, dest));

            }

            HashSet<int> visited = new HashSet<int>();
            SortedSet<(int Time, int Node)> minHeap = new SortedSet<(int Time, int Node)>();
            minHeap.Add((0, k));


            while (minHeap.Count > 0)
            {
                var currNode = minHeap.Min;
                minHeap.Remove(currNode);

                if (visited.Contains(currNode.Node))
                {
                    continue;
                }

                visited.Add(currNode.Node);
                minTime = Math.Max(minTime, currNode.Time);

                if (adjList.ContainsKey(currNode.Node))
                {
                    foreach (var neiNode in adjList[currNode.Node])
                    {
                        if (!visited.Contains(neiNode.Node))
                        {                            
                            minHeap.Add((neiNode.Time + currNode.Time, neiNode.Node));
                        }
                    }
                }
            }

            return visited.Count == n ? minTime : -1;
        }

    }
}
