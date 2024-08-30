using LeetCodeSolutions.NeetCode.Trees;

namespace InvertBST
{    
    public class InvertBinarySearchTree
    {
        public static TreeNode? InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode temp = root.left;
            root.left = root.right;
            root.right = temp;

            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }

        public static TreeNode? InvertTreeIterative(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            // Create a stack to hold nodes to be processed
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                // Pop a node from the stack
                TreeNode current = stack.Pop();

                // Swap the left and right children
                TreeNode temp = current.left;
                current.left = current.right;
                current.right = temp;

                // Push the children onto the stack to process them
                if (current.left != null)
                {
                    stack.Push(current.left);
                }
                if (current.right != null)
                {
                    stack.Push(current.right);
                }
            }

            return root;
        }

    }
}
