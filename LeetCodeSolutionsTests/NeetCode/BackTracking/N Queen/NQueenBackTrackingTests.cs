using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.BackTracking.N_Queen.Tests
{
    [TestClass()]
    public class NQueenBackTrackingTests
    {
        [TestMethod()]
        public void SolveNQueensTest()
        {
            NQueenBackTracking nQueen = new NQueenBackTracking();

            nQueen.SolveNQueens(4).Should().BeEquivalentTo(

                new List<List<String>>() {                    
                    
                    new List<string>()
                    {
                        ".Q..","...Q","Q...","..Q."
                    },

                    new List<string>()
                    {
                        "..Q.","Q...","...Q",".Q.."
                    }      
                    
                });        

        }
    }
}