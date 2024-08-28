namespace Equal_BST
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

    public class EqualBST
    {
        static bool result = true;
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (result == false)
                return false;

            if (p == q)
            {
                return true;
            }

            if ((p == null && q != null) || (p != null && q == null) || p.val != q.val)
            {
                result = false;
                return result;
            }
            
            IsSameTree(p.left, q.left);
            IsSameTree(p.right, q.right);

            return result;
        }
    }
}
