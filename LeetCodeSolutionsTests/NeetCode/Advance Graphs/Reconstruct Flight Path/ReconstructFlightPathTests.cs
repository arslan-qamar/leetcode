using FluentAssertions;

namespace LeetCodeSolutions.NeetCode.Advance_Graphs.Reconstruct_Flight_Path.Tests
{
    [TestClass()]
    public class ReconstructFlightPathTests
    {
        [TestMethod()]
        public void FindItineraryTest()
        {
            ReconstructFlightPath rcf = new ReconstructFlightPath();

            rcf.FindItinerary([["HOU", "JFK"], ["SEA", "JFK"], ["JFK", "SEA"], ["JFK", "HOU"]]).Should().BeEquivalentTo(["JFK", "HOU", "JFK", "SEA", "JFK"]);

        }
    }
}