using LeetCodeSolutions.NeetCode.Trees;

namespace Binary_Tree_Maximum_Path_Sum
{
    public class MaxPathSumFinder
    {
        public static int MaxPathSum(TreeNode root)
        {
            int DFS(TreeNode? node, ref int maxPath)
            {
                if (node == null)
                {
                    return 0;
                }

                var leftPath = Math.Max(DFS(node.left, ref maxPath), 0);
                var rightPath = Math.Max(DFS(node.right, ref maxPath), 0);
                
                maxPath = Math.Max(maxPath, node.val + leftPath + rightPath);

                return node.val + Math.Max(leftPath, rightPath);
            }

            int maxCount = root.val;
            DFS(root, ref maxCount);
            return maxCount;
        }
    }
}
