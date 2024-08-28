namespace BST_Diameter
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

    public class BSTDiameter
    {
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            int result = 0;

            int calculateDiameter(TreeNode node)
            {
                if (node == null)
                    return 0;

                int left = calculateDiameter(node.left);
                int right = calculateDiameter(node.right);

                result = Math.Max(result, left + right);

                return 1 + Math.Max(left, right);
            }

            calculateDiameter(root);

            return result;
        }
    }
}
