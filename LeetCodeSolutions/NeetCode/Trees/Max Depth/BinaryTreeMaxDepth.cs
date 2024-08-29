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

        public static int MaxDepth(TreeNode root)
        {
            int result = 0;

            int calculateHeight(TreeNode node)
            {
                if (node == null)
                    return 0;

                int left = calculateHeight(node.left);
                int right = calculateHeight(node.right);

                result = Math.Max(result, 1 + Math.Max(left, right));

                return 1 + Math.Max(left, right);
            }

            calculateHeight(root);

            return result;
        }
    }
}
