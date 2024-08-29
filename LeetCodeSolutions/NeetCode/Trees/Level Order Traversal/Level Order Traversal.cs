namespace Level_Order_Traversal
{
    public class Level_Order_Traversal
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

        public List<List<int>> LevelOrder(TreeNode root)
        {
            if(root == null)
            {
                return new List<List<int>>();
            }
            List<List<int>> result = new List<List<int>>();

            Queue<TreeNode> queue = new Queue<TreeNode>();

            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                List<int> subList = new List<int>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    subList.Add(node.val);

                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }

                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                result.Add(subList);
            }

            return result;
        }
    }
}
