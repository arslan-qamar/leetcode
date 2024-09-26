using FluentAssertions;
using LeetCodeSolutions.NeetCode.Trie.Word_Dictionary;

namespace Word_Dictionary
{
    [TestClass()]
    public class WordDictionaryTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            WordDictionary wordDictionary = new WordDictionary();
            wordDictionary.AddWord("day");
            wordDictionary.AddWord("bay");
            wordDictionary.AddWord("may");
            wordDictionary.Search("say").Should().BeFalse(); // return false
            wordDictionary.Search("day").Should().BeTrue(); // return true
            wordDictionary.Search(".ay").Should().BeTrue(); // return true
            wordDictionary.Search("b..").Should().BeTrue(); // return true
        }
    }
}