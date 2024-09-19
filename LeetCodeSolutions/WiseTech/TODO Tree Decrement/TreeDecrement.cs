namespace WiseTechPractice.Problem_4
{
    public class TreeDecrement
    {
        public static int getMinCost(List<int> val, int t_nodes, List<int> t_from, List<int> t_to)
        {
            // Build adjacency list representation of the tree
            List<List<int>> adj = new List<List<int>>(t_nodes);
            for (int i = 0; i < t_nodes; i++)
            {
                adj.Add([]);
            }

            for (int i = 0; i < t_from.Count; i++)
            {
                adj[t_from[i] - 1].Add(t_to[i] - 1);
                adj[t_to[i] - 1].Add(t_from[i] - 1);
            }

            // Run DFS from any node (node 0 in this case)
            (int totalCost, int excess) result = DFS(0, -1, adj, val.ToArray());

            // Return the total cost (excess should be 0 by the end)
            return result.totalCost;


        }

        private static (int totalCost, int excess) DFS(int node, int parent, List<List<int>> adj, int[] val)
        {
            int totalCost = 0;
            int excess = val[node]; // Initially, the node's own value is its excess

            foreach (int neighbor in adj[node])
            {
                if (neighbor != parent)
                {
                    // Recursively process the subtree
                    (int subtreeCost, int subtreeExcess) = DFS(neighbor, node, adj, val);

                    // Add the cost from the subtree
                    totalCost += subtreeCost;

                    // Add the cost of transferring excess between `node` and `neighbor`
                    totalCost += Math.Abs(subtreeExcess);

                    // Balance the excess from the subtree with the current node
                    excess += subtreeExcess;
                }
            }

            // Return the total cost for this subtree and the excess to propagate upwards
            return (totalCost, excess);
        }


        public static int getMinCost2(List<int> val, int t_nodes, List<int> t_from, List<int> t_to)
        {
            List<int>[] tree = new List<int>[t_nodes];
            for (int i = 0; i < t_nodes; i++)
                tree[i] = [];

            for (int i = 0; i < t_from.Count; i++)
            {
                tree[t_from[i] - 1].Add(t_to[i] - 1);
                tree[t_to[i] - 1].Add(t_from[i] - 1);
            }

            return DFS(0, -1, tree, val.ToArray());

            static int DFS(int node, int parent, List<int>[] adjacencyList, int[] values)
            {
                int cost = 0;

                foreach (int neighbor in adjacencyList[node])
                {
                    if (neighbor != parent)
                    {
                        cost += DFS(neighbor, node, adjacencyList, values);

                        if (values[neighbor] > values[node])
                        {
                            cost += values[neighbor];
                        }
                        else
                        {
                            cost += values[node];
                        }

                        values[node] = Math.Max(values[node], values[neighbor]);
                    }
                }

                return cost;
            }


        }


    }
}
