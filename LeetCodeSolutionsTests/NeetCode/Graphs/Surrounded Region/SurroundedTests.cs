using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Graphs.Surrounded_Region.Tests
{
    [TestClass()]
    public class SurroundedTests
    {
        [TestMethod()]
        public void SolveTest()
        {
            char[][] board = [
                              ['X','X','X','X'],
                              ['X','O','O','X'],
                              ['X','O','O','X'],
                              ['X','X','X','O']
                             ];


            Surrounded s = new Surrounded();

            s.Solve(board);


            board.Should().BeEquivalentTo(

                new char[][]{
                              ['X','X','X','X'],
                              ['X','X','X','X'],
                              ['X','X','X','X'],
                              ['X','X','X','O']
                }

                );

        }


        [TestMethod()]
        public void SolveTest2()
        {
            char[][] board = [
                              ['X','X','X','X'],
                              ['X','O','X','X'],
                              ['X','X','X','X'],
                              ['X','X','X','O']
                             ];


            Surrounded s = new Surrounded();

            s.Solve(board);


            board.Should().BeEquivalentTo(

                new char[][]{
                              ['X','X','X','X'],
                              ['X','X','X','X'],
                              ['X','X','X','X'],
                              ['X','X','X','O']
                }

                );

        }



        [TestMethod()]
        public void SolveTestNeetCode()
        {
            char[][] board = [
                ['O', 'X', 'X', 'O', 'X'],
                ['X', 'O', 'O', 'X', 'O'],
                ['X', 'O', 'X', 'O', 'X'],
                ['O', 'X', 'O', 'O', 'O'],
                ['X', 'X', 'O', 'X', 'O']];


            Surrounded s = new Surrounded();

            s.Solve(board);


            //['O', 'X', 'X', 'O', 'X'],
            //['X', 'X', 'X', 'X', 'O'],
            //['X', 'X', 'X', 'X', 'X'],
            //['O', 'X', 'O', 'O', 'O'],
            //['X', 'X', 'O', 'X', 'O']
                
                
            board.Should().BeEquivalentTo(

            new char[][]{

                    ['O','X','X','O','X'],
                    ['X','X','X','X','O'],
                    ['X','X','X','O','X'],
                    ['O','X','O','O','O'],
                    ['X','X','O','X','O']
                    });
        }

    }

}