namespace LeetCodeSolutions.NeetCode.Graphs.Clone_Graph
{
    public class CloneGraphs
    {   
        public static Node CloneGraph(Node node)
        {
            Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();            
            return Dfs(node);

            Node Dfs(Node node)
            {
                if (node == null)
                    return null;

                if (oldToNew.ContainsKey(node))
                    return oldToNew[node];

                Node copy = new Node(node.val);
                oldToNew[node] = copy;

                foreach (Node nei in node.neighbors)
                    copy.neighbors.Add(Dfs(nei));

                return copy;
            }
        }        
    }
}
