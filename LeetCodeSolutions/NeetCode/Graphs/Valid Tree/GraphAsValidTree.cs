namespace LeetCodeSolutions.NeetCode.Graphs.Valid_Tree
{
    public class GraphAsValidTree
    {
        public bool ValidTree(int n, int[][] edges)
        {
            if(n == 0 || edges.Length == 0)
            {
                return true;
            }

            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                adjList[i] = new List<int>();
            }

            foreach (var item in edges)
            {
                adjList[item[0]].Add(item[1]);
                adjList[item[1]].Add(item[0]);
            }           

            bool result =  Dfs(0);

            return result && visited.Count == n;
            

            bool Dfs(int i)
            { 
                if (visited.Contains(i))
                {
                    return false;
                }

                visited.Add(i);

                foreach (var item in adjList[i])
                {
                    adjList[item].Remove(i); //Remove the immediate edge to previous node, This would help with false positive cycle detection as the bigger loop is not broken. a<->b is broken but not a<->b<->c<->a 
                    if (!Dfs(item))
                    {
                        return false;
                    }
                }

                return true;
            }           

        }

    }
}
