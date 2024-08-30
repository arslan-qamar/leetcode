using LeetCodeSolutions.NeetCode.Trees;

namespace Good_Nodes_In_Binary_Tree
{
    public class GoodNodesCounter
    {
        
        public static int GoodNodes(TreeNode root)
        {        
            return FindGoodNodes(root, root.val);
        }

        private static int FindGoodNodes(TreeNode? node, int maxSeen)
        {

            if (node == null)
            {
                return 0;
            }

            int count = 0;
            if (node.val >= maxSeen)
            {
                count = 1;
            }

            maxSeen = Math.Max(node.val, maxSeen);

            count += FindGoodNodes(node.left, maxSeen);
            count += FindGoodNodes(node.right, maxSeen);

            return count;
        }
    }
}
