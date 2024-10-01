
namespace LeetCodeSolutions.NeetCode.Graphs.Count_Connected_Components
{
    public class ConnectedComponents
    {
        public int CountComponents(int n, int[][] edges)
        {

            int result = n;

            int[] parent = new int[n];
            int[] rank = new int[n];

            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }


            foreach (var edge in edges)
            {

                result -= Union(edge[0], edge[1]);
                    
            }

            
            int Union(int v1, int v2)
            {
                int p1 = FindParent(v1);
                int p2 = FindParent(v2);

                if (p1 == p2)
                {
                    return 0;
                }

                if (rank[p1] > rank[p2])
                {
                    parent[p2] = p1;
                    rank[p1] += rank[p2];
                }
                else
                {
                    parent[p1] = p2;
                    rank[p2] += rank[p1];
                }

                return 1;
            }

            int FindParent(int v)
            {
                int res = v;

                while(res != parent[res])
                {
                    parent[res] = parent[parent[res]];  //This shortens the traversal
                    res = parent[res];
                }

                return res;
            }

            return result;
        }

        

        public int CountComponentsDFS(int n, int[][] edges)
        {
            int components = 0;

            if (n == 0)
            {
                return components;
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


            foreach (var item in adjList)
            {
                if(item.Value.Count == 0)
                {
                    visited.Add(item.Key);
                    components++;
                }
            }

            for (int i = 0; i < n ; i++)
            {
                if (!visited.Contains(i))
                {
                    Dfs(i);
                    components++;
                }
            }            

            return components;


            void Dfs(int i)
            {
                if (visited.Contains(i))
                {
                    return;
                }

                visited.Add(i);

                foreach (var item in adjList[i])
                {
                    Dfs(item);                    
                }

                return ;
            }
        }
    }
}
