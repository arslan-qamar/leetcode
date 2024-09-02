using Serialise_Deserialise_Binary_Tree;
using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trees;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Serialise_Deserialise_Binary_Tree.Tests
{
    [TestClass()]
    public class SerialiseDeserialiseTests
    {
        [TestMethod()]
        public void SerializeTest()
        {
            SerialiseDeserialise.Serialize(
                new TreeNode(1, new TreeNode(2), new TreeNode(3))).Should().Be("1,2,null,null,3,null,null");
        }

        [TestMethod()]
        public void SerializeTest2()
        {
            SerialiseDeserialise.Serialize(
                new TreeNode(1)).Should().Be("1,null,null");
        }


        [TestMethod()]
        public void SerializeTest3()
        {
            SerialiseDeserialise.Serialize(null).Should().Be("null");
        }

        [TestMethod()]
        public void DeserializeTest()
        {            
            TreeNode root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
         
            string serialised = SerialiseDeserialise.Serialize(root);

            SerialiseDeserialise.Deserialize(serialised).Should().BeEquivalentTo(root);
        }

        [TestMethod()]
        public void DeserializeTest2()
        {
            TreeNode root = null;

            string serialised = SerialiseDeserialise.Serialize(root);

            SerialiseDeserialise.Deserialize(serialised).Should().BeEquivalentTo(root);
        }

        [TestMethod()]
        public void DeserializeTest3()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2));

            string serialised = SerialiseDeserialise.Serialize(root);

            SerialiseDeserialise.Deserialize(serialised).Should().BeEquivalentTo(root);
        }

    }
}