﻿using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Graphs.Islands_and_Treasure.Tests
{
    [TestClass()]
    public class IslandTreasureTests
    {
        [TestMethod()]
        public void islandsAndTreasureTest()
        {
            int[][] grid = [
                              [2147483647,-1,0,2147483647],
                              [2147483647,2147483647,2147483647,-1],
                              [2147483647,-1,2147483647,-1],
                              [0,-1,2147483647,2147483647]
                            ];
            IslandTreasure.islandsAndTreasure(grid);
            grid.Should().BeEquivalentTo(

                new int[][] { 
                [3,-1,0,1],                              
                [2,2,1,-1],
                [1,-1,2,-1],
                [0,-1,3,4]
                });
        }

        [TestMethod()]
        public void islandsAndTreasureTestNeetCodeFailed()
        {
            int[][] grid = [
                [2147483647, 0,          2147483647,    2147483647, 2147483647], 
                [2147483647, 2147483647, -1,            2147483647, 2147483647], 
                [2147483647, 2147483647, 2147483647,    -1,         2147483647], 
                [0,          2147483647, -1,            2147483647, 2147483647], 
                [2147483647, 2147483647, 2147483647,    0,          2147483647]
                ];
            
            IslandTreasure.islandsAndTreasure(grid);

            grid.Should().BeEquivalentTo(
                new int[][]{
                [1, 0, 1, 2, 3],
                [2, 1, -1, 3, 4],
                [1, 2, 3, -1, 3],
                [0, 1, -1, 1, 2],
                [1, 2, 1, 0, 1]
                }
                );
        }
    }
}