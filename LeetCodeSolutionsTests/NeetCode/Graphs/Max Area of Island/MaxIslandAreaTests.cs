using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Max_Area_of_Island;

namespace Max_Area_of_Island
{
    [TestClass()]
    public class MaxIslandAreaTests
    {
        [TestMethod()]
        public void MaxAreaOfIslandTest()
        {
            var maxIslandArea = new MaxIslandArea();

            int[][] grid = [
                              [0,1,1,0,1],
                              [1,0,1,0,1],
                              [0,1,1,0,1],
                              [0,1,0,0,1]
                           ];

            maxIslandArea.MaxAreaOfIsland(grid).Should().Be(6);
               
        }

        [TestMethod()]
        public void MaxAreaOfIslandTestZero()
        {
            var maxIslandArea = new MaxIslandArea();

            int[][] grid = [
                              [0,0,0,0,0],
                              [0,0,0,0,0],
                              [0,0,0,0,0],
                              [0,0,0,0,0]
                           ];

            maxIslandArea.MaxAreaOfIsland(grid).Should().Be(0);

        }

        [TestMethod()]
        public void MaxAreaOfIslandTest20()
        {
            var maxIslandArea = new MaxIslandArea();

            int[][] grid = [
                              [1,1,1,1,1],
                              [1,1,1,1,1],
                              [1,1,1,1,1],
                              [1,1,1,1,1]
                           ];

            maxIslandArea.MaxAreaOfIsland(grid).Should().Be(20);

        }


        [TestMethod()]
        public void MaxAreaOfIslandTestTricky()
        {
            var maxIslandArea = new MaxIslandArea();

            int[][] grid = [
                              [1,1,1,1,1],
                              [1,0,0,0,1],
                              [1,0,0,0,1],
                              [1,1,1,1,1]
                           ];

            maxIslandArea.MaxAreaOfIsland(grid).Should().Be(14);

        }


        [TestMethod()]
        public void MaxAreaOfIslandTestFailedNeetCode()
        {
            var maxIslandArea = new MaxIslandArea();

            int[][] grid = [
                [0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0], 
                [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0], 
                [0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0],
                [0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 1, 0, 0], 
                [0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 1, 0, 0], 
                [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0], 
                [0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0], 
                [0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0]
                ];

            maxIslandArea.MaxAreaOfIsland(grid).Should().Be(6);

        }

    }
}