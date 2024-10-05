namespace Advance_Graphs.ConnectAllPoints
{
    public class ConnectAllPoints
    {
        public int MinCostConnectPoints(int[][] points)
        {
            int totalDis = 0;

            Dictionary<int, List<(int Index, int Distance)>> adjList = new Dictionary<int, List<(int Index, int Distance)>>();

            for (int i = 0; i < points.Length; i++)
            {
                int x1 = points[i][0];
                int y1 = points[i][1];

                if (!adjList.ContainsKey(i))
                {
                    adjList[i] = new List<(int, int)>();
                }

                for (int j = i+1; j < points.Length; j++)
                {
                    int x2 = points[j][0];
                    int y2 = points[j][1];

                    int dis = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
                    adjList[i].Add((j, dis));

                    if(!adjList.ContainsKey(j))
                    {
                        adjList[j] = new List<(int Index, int Distance)>();
                    }
                    adjList[j].Add((i, dis));
                }
            }


            SortedSet<(int Distance, int Index)> sortedSet = new SortedSet<(int Distance, int Index)>();            
            HashSet<int> visited = new HashSet<int>();

            sortedSet.Add((adjList.First().Key,0));

            while (sortedSet.Count > 0)
            {
                (int Distance, int Index) node = sortedSet.Min;
                sortedSet.Remove(node);

                if(visited.Contains(node.Index))
                {
                    continue;
                }

                totalDis += node.Distance;
                visited.Add(node.Index);

                if (adjList.ContainsKey(node.Index))
                {
                    foreach (var nei in adjList[node.Index])
                    {
                        if(!visited.Contains(nei.Index))
                        {
                            sortedSet.Add((nei.Distance, nei.Index));
                        }
                    }
                }
            }



            return totalDis;

        }

    }
}
