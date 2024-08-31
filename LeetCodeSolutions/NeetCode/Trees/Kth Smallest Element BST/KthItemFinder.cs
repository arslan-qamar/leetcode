using LeetCodeSolutions.NeetCode.Trees;

namespace Kth_Smallest_Element_BST
{
    public class KthItemFinder
    {
        public static int KthSmallest(TreeNode root, int k)
        {

            Stack<TreeNode> stack = new Stack<TreeNode>();

            TreeNode curr = root;

            while (stack.Count > 0  || curr !=null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }

                curr = stack.Pop();
                k--;

                if(k == 0)
                {
                    return curr.val;
                }

                curr = curr.right;
            }

            return -1;
        }
    }
}
