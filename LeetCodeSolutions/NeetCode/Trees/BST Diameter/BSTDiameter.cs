using LeetCodeSolutions.NeetCode.Trees;

namespace BST_Diameter
{ 
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
