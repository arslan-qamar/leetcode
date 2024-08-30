using LeetCodeSolutions.NeetCode.Trees;

namespace Balanced_BST_Checker
{
    public class BSTBalanceChecker
    {
       
        public static bool IsBalanced(TreeNode root)
        {
            bool result = true;

            int CheckHeights(TreeNode node)
            {
                if(node == null || result == false)
                {
                    return 0;
                }

                int left = CheckHeights(node.left);
                int right = CheckHeights(node.right);

                if(left - right > 1 || left -  right < -1)
                {
                    result = false;
                }

                return 1 + Math.Max(left, right);
            }

            CheckHeights(root);

            return result;            
        }
    }
}
