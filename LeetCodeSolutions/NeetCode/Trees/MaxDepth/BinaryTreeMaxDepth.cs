namespace Trees.MaxDepth
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    
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
