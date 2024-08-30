using LeetCodeSolutions.NeetCode.Trees;

namespace Equal_BST
{  
    public class EqualBST
    {        
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p != null && q != null && p.val == q.val)
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }

            return false;
        }
    }
}
