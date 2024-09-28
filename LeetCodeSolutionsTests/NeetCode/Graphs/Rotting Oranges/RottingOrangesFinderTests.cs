using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Rotting_Oranges;

namespace Rotting_Oranges_Tests
{
    [TestClass()]
    public class RottingOrangesFinderTests
    {
        [TestMethod()]
        public void OrangesRottingTest()
        {

            RottingOrangesFinder rf = new RottingOrangesFinder();

            rf.OrangesRotting(new int[][]
            {
                [1,1,0],
                [0,1,1],
                [0,1,2]
            }).Should().Be(4);            
        }

        [TestMethod()]
        public void OrangesRottingTest2()
        {

            RottingOrangesFinder rf = new RottingOrangesFinder();

            rf.OrangesRotting(new int[][]
            {
                [1,0,1],[0,2,0],[1,0,1]
            }).Should().Be(-1);
        }


        [TestMethod()]
        public void OrangesRottingTestNeetCodeFailed()
        {

            RottingOrangesFinder rf = new RottingOrangesFinder();

            rf.OrangesRotting(new int[][]
            {
                [2,1,1],
                [0,1,1],
                [1,0,1]
            }).Should().Be(-1);
        }

        [TestMethod()]
        public void OrangesRottingTestNeetCodeFailed2()
        {

            RottingOrangesFinder rf = new RottingOrangesFinder();

            rf.OrangesRotting(new int[][]
            {
                [0, 2]
            }).Should().Be(0);
        }
        

    }
}