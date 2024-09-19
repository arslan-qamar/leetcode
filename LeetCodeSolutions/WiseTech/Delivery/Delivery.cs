namespace WiseTechPractice.Test_4
{
    public class Delivery
    {
        public static List<int> order(int cityNodes, List<int> cityFrom, List<int> cityTo, int company)
        {
            Dictionary<int, List<int>> roadGraph = BuildGraph(cityFrom, cityTo);

            HashSet<int> visited = [];
            SortedSet<(int distance, int city)> minHeap = [];
            List<int> orderedVisit = [];

            minHeap.Add((0, company));

            while (minHeap.Count > 0)
            {
                (int dis, int city) = minHeap.Min;
                minHeap.Remove(minHeap.Min);

                if (!visited.Contains(city))
                {
                    visited.Add(city);
                    if (roadGraph.ContainsKey(city))
                    {
                        foreach (int neighbor in roadGraph[city])
                        {
                            if (!visited.Contains(neighbor))
                            {
                                minHeap.Add((dis + 1, neighbor));
                            }
                        }
                    }
                    orderedVisit.Add(city);
                }
            }

            return orderedVisit.Skip(1).ToList();
        }

        private static Dictionary<int, List<int>> BuildGraph(List<int> cityFrom, List<int> cityTo)
        {
            Dictionary<int, List<int>> roadGraph = [];

            for (int i = 0; i < cityFrom.Count; i++)
            {
                if (!roadGraph.ContainsKey(cityTo[i]))
                    roadGraph[cityTo[i]] = [];
                if (!roadGraph.ContainsKey(cityFrom[i]))
                    roadGraph[cityFrom[i]] = [];

                roadGraph[cityTo[i]].Add(cityFrom[i]);
                roadGraph[cityFrom[i]].Add(cityTo[i]);
            }

            return roadGraph;
        }


    }

}
