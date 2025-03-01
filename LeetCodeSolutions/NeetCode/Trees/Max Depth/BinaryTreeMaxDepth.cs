﻿using LeetCodeSolutions.NeetCode.Trees;

namespace Trees.MaxDepth
{
    public class BinaryTreeMaxDepth
    {

        public static int MaxDepth(TreeNode root)
        {
            int result = 0;

            int calculateHeight(TreeNode node)
            {
                if (node == null)
                    return 0;

                int left = calculateHeight(node.left);
                int right = calculateHeight(node.right);

                result = Math.Max(result, 1 + Math.Max(left, right));

                return 1 + Math.Max(left, right);
            }

            calculateHeight(root);

            return result;
        }
    }
}
