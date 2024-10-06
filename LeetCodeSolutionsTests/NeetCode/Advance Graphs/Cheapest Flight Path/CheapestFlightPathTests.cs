using FluentAssertions;
using LeetCodeSolutions.NeetCode.Advance_Graphs.Cheapest_Flight_Path;

namespace Cheapest_Flight_Path.Tests
{
    [TestClass()]
    public class CheapestFlightPathTests
    {
        [TestMethod()]
        public void FindCheapestPriceTest()
        {
            CheapestFlightPath cp = new CheapestFlightPath();

            cp.FindCheapestPrice(4, [[0, 1, 200], [1, 2, 100], [1, 3, 300], [2, 3, 100]], 0, 3, 1).Should().Be(500);
        }

    }
}