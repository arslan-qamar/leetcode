using LeetCodeSolutions.NeetCode.Trees;

namespace SubTree_Checker
{

    public class SubTreeChecker
    {
       
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null)
                return true;
            

            if (root == null)
                return false;
                        
            return SameTree(root, subRoot) ||  IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }


        public bool SameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }

            if (p != null && q != null && p.val == q.val)
            {
                return SameTree(p.left, q.left) && SameTree(p.right, q.right);
            }

            return false;
        }
    }
}
