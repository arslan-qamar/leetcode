namespace Lowest_Common_Ancestor_of_BST
{
    public class LowestCommonAncestorFinder
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

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {

            TreeNode curr = root;

            while (true)
            {
                if (p.val > curr.val && q.val > curr.val)
                {
                    curr = curr.right;
                }
                else if (p.val < curr.val && q.val < curr.val)
                {
                    curr = curr.left;
                }
                else
                {
                    return curr;
                }
            }           

        }

        private (int height, bool found) treeContains(TreeNode root, TreeNode target)
        {
            if (root == null)
            {
                return (-1, false);
            }

            if(root.val == target.val)
            {
                return (0, true);
            }

            (int height, bool found) leftedges = treeContains(root.left, target);
            (int height, bool found) rightedges = treeContains(root.right, target);

            if (leftedges.found || rightedges.found)
            {
                return (1 + Math.Max(leftedges.height, rightedges.height), true);
            }

            return (int.MinValue, false);
        }
    }
}
