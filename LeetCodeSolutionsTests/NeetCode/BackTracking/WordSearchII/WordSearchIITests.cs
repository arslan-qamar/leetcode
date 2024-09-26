using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.BackTracking.WordSearchII.Tests
{
    [TestClass()]
    public class WordSearchIITests
    {
        [TestMethod()]
        public void FindWordsTest()
        {
            var ws = new WordSearchII();

            char[][] board = new char[][]
                {
                    ['a','b','c','d'],
                    ['s','a','a','t'],
                    ['a','c','k','e'],
                    ['a','c','d','n']

                };

            ws.FindWords(board, new string[] { "bat", "cat", "back", "backend", "stack" }).Should().BeEquivalentTo(new List<string>() { "cat", "back", "backend" });
        }

        [TestMethod()]
        public void FindWordsTest2()
        {
            var ws = new WordSearchII();

            char[][] board = new char[][]
                {
                    ['a','b','c'],
                    ['a','e','d'],
                    ['a','f','g']
                };

            ws.FindWords(board, new string[] { "abcdefg", "gfedcbaaa", "eaabcdgfa", "befa", "dgc", "ade" })
                .Should().BeEquivalentTo(new List<string>() { "abcdefg", "befa", "eaabcdgfa", "gfedcbaaa" });
        }
    }
}