using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trie;

namespace PrefixTreeTests
{
    [TestClass()]
    public class PrefixTreeTests
    {

        [TestMethod()]
        public void SearchTest()
        {
            PrefixTree prefixTree = new PrefixTree();
            prefixTree.Insert("dog");
            prefixTree.Search("dog").Should().BeTrue();    // return true
            prefixTree.Search("do").Should().BeFalse();     // return false
            prefixTree.StartsWith("do").Should().BeTrue(); // return true
            prefixTree.Insert("do");
            prefixTree.Search("do").Should().BeTrue();     // return true
        }

    }
}