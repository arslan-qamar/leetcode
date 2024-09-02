using LeetCodeSolutions.NeetCode.Trees;

namespace Serialise_Deserialise_Binary_Tree
{
    public class SerialiseDeserialise
    {
        // Encodes a tree to a single string.
        public static string Serialize(TreeNode? root)
        {
            if (root == null)
                return "null";


            string leftValue = Serialize(root.left);
            string rightValue = Serialize(root.right);


            return root.val + "," + leftValue + "," + rightValue;
        }

        // Decodes your encoded data to tree.
        public static TreeNode? Deserialize(string data)
        {
            TreeNode? Deserialize(string[] data, ref int index)
            {
                if (data[index] == "null" || index >= data.Length)
                {
                    return null;
                }

                TreeNode node = new TreeNode(int.Parse(data[index]));

                index = index + 1;
                node.left = Deserialize(data,ref index);


                index = index + 1;
                node.right = Deserialize(data, ref index);


                return node;
            }

            int idx = 0;
            return Deserialize(data.Split(','), ref idx);
        }
    }
}
