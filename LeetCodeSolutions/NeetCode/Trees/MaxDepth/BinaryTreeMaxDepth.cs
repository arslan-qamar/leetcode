using LeetCodeSolutions.NeetCode.Trees.InvertBST;

namespace LeetCodeSolutions.NeetCode.Trees.MaxDepth
{
    public class BinaryTreeMaxDepth
    {
        private static int MDepth = 0;
        public static int MaxDepth(TreeNode root)
        {
            MaxDepth(root, 0);
            return MDepth;
        }

        public static void MaxDepth(TreeNode root, int depth)
        {

            if (root == null)
            {
                MDepth = Math.Max(MDepth, depth);
                return;
            }

            depth++;

            MaxDepth(root.left, depth);
            MaxDepth(root.right, depth);
        }
    }
}
