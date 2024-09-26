using FluentAssertions;
using LeetCodeSolutions.NeetCode.BackTracking.NumIslands;

namespace IslandsTest
{
    [TestClass()]
    public class NumberOfIslandsTests
    {
        [TestMethod()]
        public void NumIslandsTest()
        {
            char[][] grid = new char[][] {
                                            ['0', '1', '1', '1', '0'],
                                            ['0', '1', '0', '1', '0'],
                                            ['1', '1', '0', '0', '0'],
                                            ['0', '0', '0', '0', '0']
            };

            NumberOfIslands.NumIslands(grid).Should().Be(1);
        }

        [TestMethod()]
        public void NumIslandsTest2()
        {
            char[][] grid = new char[][] {
                                             ['1','1','0','0','1'],
                                             ['1','1','0','0','1'],
                                             ['0','0','1','0','0'],
                                             ['0','0','0','1','1']
            };

            NumberOfIslands.NumIslands(grid).Should().Be(4);
        }
    }
}