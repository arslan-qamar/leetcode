using FluentAssertions;
using LeetCodeSolutions.NeetCode.Graphs.Pacific_Atlantic_Water_Flow;

namespace Pacific_Atlantic_Water_Flow.Tests
{
    [TestClass()]
    public class PacificAtlanticWaterFlowTests
    {
        [TestMethod()]
        public void PacificAtlanticTest()
        {

            PacificAtlanticWaterFlow pw = new PacificAtlanticWaterFlow();


            pw.PacificAtlantic
                ([
                  [4,2,7,3,4],
                  [7,4,6,4,7],
                  [6,3,5,3,6]
                ]).Should().BeEquivalentTo(
                 new List<List<int>>(){
                     new List<int>{0, 2},
                     new List<int>{0, 4},
                     new List<int>{1, 0},
                     new List<int>{1, 1},
                     new List<int>{1, 2},
                     new List<int>{1, 3},
                     new List<int>{1, 4},
                     new List<int>{2, 0}
                 }
                );


        }
    }
}