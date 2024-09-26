using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking.WordSearch;

namespace WordSearchTests
{
    [TestClass()]
    public class WordSearchTests
    {
        [TestMethod()]
        public void ExistTest()
        {
            WordSearch.Exist(
                new char[][]
                {
                    ['A','B','C','D'],
                    ['S','A','A','T'],
                    ['A','C','A','E']

                }, "CAS"
                ).Should().BeTrue();
        }

        [TestMethod()]
        public void ExistTest2()
        {
            WordSearch.Exist(
                new char[][]
                {
                    ['A', 'B', 'C', 'E'],
                    ['S', 'F', 'C', 'S'],
                    ['A', 'D', 'E', 'E']

                }, "ABCB"
                ).Should().BeFalse();
        }


        [TestMethod()]
        public void ExistTest3()
        {
            WordSearch.Exist(
                new char[][]
                {
                    ['C', 'A', 'A'],
                    ['A', 'A', 'A'],
                    ['B', 'C', 'D']

                }, "AAB"
                ).Should().BeTrue();
        }

        [TestMethod()]
        public void ExistTest4()
        {
            WordSearch.Exist(
                new char[][]
                {
                    ['A','B','C','E'],
                    ['S','F','E','S'],
                    ['A','D','E','E']

                }, "ABCESEEEFS"
                ).Should().BeTrue();
        }
    }
}