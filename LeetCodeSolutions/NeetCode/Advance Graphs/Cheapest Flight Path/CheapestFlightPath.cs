namespace LeetCodeSolutions.NeetCode.Advance_Graphs.Cheapest_Flight_Path
{
    public class CheapestFlightPath
    {
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            //BellmanFord Algorithm
            int[] prices = new int[n];
            Array.Fill(prices, int.MaxValue);

            prices[src] = 0;

            for (int i = 0; i <= k; i++)
            {
                int[] tmp = (int[])prices.Clone();
                foreach (var flight in flights)
                {
                    int s = flight[0];
                    int d = flight[1];
                    int p = flight[2];

                    if (prices[s] == int.MaxValue)
                    {
                        continue;
                    }

                    tmp[d] = Math.Min(tmp[d], prices[s] + p);
                }
                prices = tmp;
            }

            return prices[dst] == int.MaxValue ? -1 : prices[dst];
        }



        public int FindCheapestPriceDjikstra(int n, int[][] flights, int src, int dst, int k)
        {
            int cost = int.MaxValue;

            Dictionary<int, List<(int Price, int Node)>> adjList = new Dictionary<int, List<(int Price, int Node)>>();

            foreach (var flight in flights)
            {
                int from = flight[0];
                int to = flight[1];
                int price = flight[2];

                if(!adjList.ContainsKey(from))
                {
                    adjList[from] = new List<(int Price, int Node)>();
                }

                adjList[from].Add((price, to));
            }


            if (!adjList.ContainsKey(src))
            {
                return -1;
            }

            SortedSet<(int Cost, int Node, int hops)> minHeap = new SortedSet<(int Cost, int Node, int hops)>();
            minHeap.Add((0, src, 0));
            HashSet<int> visited = new HashSet<int>();

            
            while(minHeap.Count  > 0)
            {
                var stop = minHeap.Min;
                minHeap.Remove(stop);

                if(stop.Node == dst)
                {
                    cost = Math.Min(cost, stop.Cost);
                    break;
                }
                
                if (stop.hops <= k)
                {
                    if(adjList.ContainsKey(stop.Node))
                    {

                        foreach (var nextStop in adjList[stop.Node])
                        {
                            if (stop.hops <= k)
                            {
                                minHeap.Add((stop.Cost + nextStop.Price, nextStop.Node, stop.hops + 1));
                            }
                        }
                    }
                }
            }

            return cost == int.MaxValue ? -1 : cost;

        }

    }
}
