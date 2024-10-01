namespace LeetCodeSolutions.NeetCode.Graphs.Redundant_Connection
{
    public class RedundantConnection
    {

        public int[] FindRedundantConnection(int[][] edges)
        {
            int[] result = new int[0];


            int[] parent = new int[edges.Length+1];
            int[] rank = new int[edges.Length+1];

            for (int i = 0; i <= edges.Length; i++)
            {
                parent[i] = i;
                rank[i] = 1;
            }

            foreach (var edge in edges)
            {
                int p1 = FindParent(edge[0]);
                int p2 = FindParent(edge[1]);

                if(Union(p1,p2) == 0)
                {
                    return edge;
                }
            }

            int Union(int p1, int p2)
            {
                if(p1 == p2)
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

            int FindParent(int i)
            {
                int res = i;

                while (parent[res] != res)
                {
                    parent[res] = parent[parent[res]];
                    res = parent[res];
                }

                return parent[res];
            }

            return result;
        }



    }
}
