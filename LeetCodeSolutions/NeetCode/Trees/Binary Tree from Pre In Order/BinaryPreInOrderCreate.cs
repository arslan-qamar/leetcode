using LeetCodeSolutions.NeetCode.Trees;

namespace Binary_Tree_from_Pre_In_Order
{
    public class BinaryPreInOrderCreate
    {

        public static TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            
            if(preorder == null || inorder == null || preorder.Length == 0 || inorder.Length == 0)
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[0]);

            int index = Array.IndexOf(inorder, preorder[0]);

            int[] leftElements = inorder.Take(index).ToArray();
            int[] newLeftPreorder = preorder.Skip(1).Take(index).ToArray();


            int[] rightElements = inorder.Skip(index + 1).ToArray();
            int[] newRightPreorder = preorder.Skip(index + 1).ToArray();


            root.left = BuildTree(newLeftPreorder, leftElements);
            root.right = BuildTree(newRightPreorder, rightElements);

            return root;
        }

    }
}
