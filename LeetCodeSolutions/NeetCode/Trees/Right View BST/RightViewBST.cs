using LeetCodeSolutions.NeetCode.Trees;

namespace Right_View_BST
{
    public class RightViewBST
    {
        public static List<int> RightSideView(TreeNode root)
        {
            List<int> result = new List<int>(); 
            
            if (root == null)
            {
                return result;                
            }
            
            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while(queue.Count > 0)
            {
                int currQueueCount = queue.Count;

                for (int i = 0; i < currQueueCount - 1; i++)
                {
                    TreeNode node = queue.Dequeue();
                    AddChildren(queue, node);
                }

                TreeNode rightNode = queue.Dequeue();
                result.Add(rightNode.val);
                AddChildren(queue, rightNode);  
            }

            return result;
        }

        private static void AddChildren(Queue<TreeNode> queue, TreeNode node)
        {
            if (node.left != null)
            {
                queue.Enqueue(node.left);
            }
            if (node.right != null)
            {
                queue.Enqueue(node.right);
            }
        }
    }
}
