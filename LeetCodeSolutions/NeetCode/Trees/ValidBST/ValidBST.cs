namespace LeetCodeSolutions.NeetCode.Trees.ValidBST
{
    public class ValidBST
    {
        public static bool IsValidBST(TreeNode root)
        {
            bool TraverseBST(TreeNode node, int left, int right)
            {
                
                if (node == null)
                {
                    return true;
                }

                if (left > node.val || node.val > right)
                {
                    return false;
                }
               
                
                return
                    TraverseBST(node.left, left, node.val) 
                    &&  
                    TraverseBST(node.right, node.val, right);
            }

            return TraverseBST(root, int.MinValue, int.MaxValue);           

        }       
        
    }
}
